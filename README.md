# Industrial Camera Control

## Description

The purpose of this project was to create a digital system with which to control the YW500 industrial camera. In doing so, I used generalized controls and built a USB Camera controller. 

The controller uses DirectShow and EMGU CV to capture direct video stream from the USB camera, and then allows for the following features: 

  1. Still Image Capture
  2. Video Capture
  3. Frame Averaging
  4. Filtering: Smooth, Median, Bilateral, Gaussian, Sobel
  5. Color Adjustment:  Color, Greyscale
  6. Camera Settings Control:  Resolution, FPS, Brightness, Hue, Saturation, Sharpness, Contrast, Iris Control, Exposure, etc.
  
 It is currently setup for the YW500, but could be easily modified for other cameras, and will work with most USB cameras as is, provided the resolution and FPS options match the YW500 camera.
 
 
