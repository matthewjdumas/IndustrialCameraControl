using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectShowLib;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;


namespace XRayCamera
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture = null;
        private bool _recording = false;
        Image<Bgr, Byte> displayFrame = null;
        private System.Timers.Timer _newFrame = new System.Timers.Timer();

        private VideoWriter _vw = null; 

        private int _fps = 15;
        private Size _sz = new Size(1920, 1080);

        private List<Image<Bgr, Byte>> framesToAvg = new List<Image<Bgr, byte>>();

        public Form1()
        {
            InitializeComponent();

            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                cameraList.Items.Add(_SystemCamereas[i].Name);
            }

            cameraList.SelectedIndex = 0;
            stoLoc.Text = "C:\\CamSaves";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;     
        }

        private void setRadioButtons(bool value)
        {
            radioButton1.Enabled = value;
            radioButton2.Enabled = value;
            radioButton3.Enabled = value;
            radioButton4.Enabled = value;
        }
        private void DoWriteFrame()
        {
            //if we wanted to compresse the image to a smaller size to save space on our video we could use
            //frame.Resize(100,100, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR)
            //But the VideoWriter must be set up with the correct size

            if (_vw.Ptr != IntPtr.Zero)
            {
                _vw.Write(displayFrame.Mat); //If we are recording and videowriter is avaliable add the image to the videowriter 
                                             //Update frame number

            }
        }

        private Image<Bgr, byte> ApplyFilter(Image<Bgr, byte> input)
        {
            Image<Bgr, byte> output = input;

            if (smoothFilterEn.Checked)
            {
                output = output.SmoothBlur((int)smoothWidth.Value, (int)smoothHeight.Value, smoothScaling.Checked);
            }
            if (medianFilterEn.Checked)
            {
                output = output.SmoothMedian((int)medianSize.Value);
            }
            if (bilateralFilterEn.Checked)
            {
                output = output.SmoothBilatral((int)kernelSize.Value, (int)colorSigma.Value, (int)spaceSigma.Value);
            }

            if (gaussEn.Checked)
            {
                output = output.SmoothGaussian((int)kernelWidth.Value, (int)kernelHeight.Value, (double)standardDevHor.Value, (double)standardDevVer.Value);
            }
            
            if (sobelEn.Checked)
            {
                Image<Bgr, float> temp = output.Convert<Bgr, float>();
                temp = temp.Sobel((int)xOrder.Value, (int)yOrder.Value, (int)aperatureSize.Value);
                output = temp.Convert<Bgr, byte>();

            }

            return output;
        

        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null) {
                Image<Bgr, Byte> frame = _capture.QueryFrame().ToImage<Bgr, Byte>();
                var color = colorSettings.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (color.Text == "Gray")
                {
                    Image<Gray, Byte> temp = frame.Convert<Gray, Byte>();
                    frame = temp.Convert<Bgr, Byte>();
                }

                if (displayFrame == null)
                {
                    displayFrame = frame;      
                }
                if (frame != null)
                {
                    if (frameAvg.Value == 1)
                    {
                        displayFrame = frame;                       
                    } else
                    {
                        if (framesToAvg.Count < frameAvg.Value)
                        {
                            framesToAvg.Add(frame);
                        }
                        try
                        {
                            if (framesToAvg.Count >= frameAvg.Value)
                            {
                                displayFrame = framesToAvg[0];

                                for (int i = displayFrame.Rows - 1; i > 0; i--)
                                {
                                    for (int j = displayFrame.Cols - 1; j > 0; j--)
                                    {
                                        int r = 0;
                                        int g = 0;
                                        int b = 0;

                                        for (int f = 0; f < framesToAvg.Count; f++)
                                        {
                                            r += (int)framesToAvg[f].Data[i, j, 0];
                                            g += (int)framesToAvg[f].Data[i, j, 1];
                                            b += (int)framesToAvg[f].Data[i, j, 2];
                                        }


                                        r = (int)(r / frameAvg.Value);
                                        g = (int)(g / frameAvg.Value);
                                        b = (int)(b / frameAvg.Value);

                                        displayFrame.Data[i, j, 0] = (byte)r;
                                        displayFrame.Data[i, j, 0] = (byte)g;
                                        displayFrame.Data[i, j, 0] = (byte)b;


                                    }
                                }


                                

                                framesToAvg = new List<Image<Bgr, byte>>();
                            }
                        }
                        catch
                        {

                        }
                        
                }

                    displayFrame = ApplyFilter(displayFrame);

                previewPane.Image = displayFrame;
                if (_recording)
                {
                    DoWriteFrame();
                }

                }
            }
                
        
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            if (captureButton.Text == "Start Capture")
            {
                captureButton.Text = "Stop Capture";
                setRadioButtons(false);

                int cam = cameraList.SelectedIndex;

                _capture = new VideoCapture(cam);

                var fpsButton = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                var resButton = groupBox3.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (fpsButton.Text == "15")
                {
                    _capture.SetCaptureProperty(CapProp.Fps, 15);
                    _fps = 15;
                }
                 else
                {
                    _capture.SetCaptureProperty(CapProp.Fps, 30);
                    _fps = 30;
                }

                if (resButton.Text == "1920 x 1080")
                {
                    _capture.SetCaptureProperty(CapProp.FrameHeight, 1080);
                    _capture.SetCaptureProperty(CapProp.FrameWidth, 1920);
                    _sz = new Size(1920, 1080);
                }
                else
                {
                    _capture.SetCaptureProperty(CapProp.FrameHeight, 1944);
                    _capture.SetCaptureProperty(CapProp.FrameWidth, 2592);
                    _sz = new Size(2592, 1944);
                }

                cameraSettingsBtn.Enabled = true;


                _newFrame.Interval = (int)(1000.0 / _capture.GetCaptureProperty(CapProp.Fps));
                _newFrame.Elapsed += new System.Timers.ElapsedEventHandler(ProcessFrame);
                _newFrame.Start();
                //Application.Idle += ProcessFrame;


            } else
            {
                captureButton.Text = "Start Capture";
                cameraSettingsBtn.Enabled = false;
                setRadioButtons(true);
                _newFrame.Stop();
                StopRecording();                
                if (_capture != null)
                    _capture.Dispose();
                //Application.Idle -= ProcessFrame; 


            }
        }

        private void StopRecording()
        {
            recordVideo.Text = "Start Recording";
            if (_recording) {

            
                if (_vw.IsOpened)
                {
                    _vw.Dispose();
                }
                _recording = false;
            }
        }

        private void takeSnapshot_Click(object sender, EventArgs e)
        {
            string fileName = string.Format("Snapshot-{0:yyyy-MM-dd_hh-mm-ss-tt}.png", DateTime.Now);
            displayFrame.Save(stoLoc.Text + "\\" + fileName);
        }

        private void recordVideo_Click(object sender, EventArgs e)
        {
            string fileName = stoLoc.Text + "\\" + string.Format("Recording-{0:yyyy-MM-dd_hh-mm-ss-tt}.avi", DateTime.Now);
            if (recordVideo.Text == "Start Recording")
            {
                recordVideo.Text = "Stop Recording";
                bool _isColor = false;

                var color = colorSettings.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (color.Text == "Color" || color.Text == "Gray")
                {
                    _isColor = true;
                }

                _vw = new VideoWriter(fileName, _fps, _sz, _isColor);
                _recording = true;
            } else 
            {
                StopRecording();
            }

        }

        private void changeLoc_Click(object sender, EventArgs e)
        {
            DialogResult result = browseDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                stoLoc.Text = browseDlg.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _capture.SetCaptureProperty(CapProp.Settings, 1);
        }
    }
}
