MIT-Kinect
==========

Mathematical Imagery Trainer (for Kinect) Documentation

Set-up
---------------
Don’t plug in your Kinect yet!

To run the MIT on Windows, download the Kinect SDK Beta2 from here: http://www.microsoft.com/download/en/details.aspx?id=27876.  Most likely, your computer is running 32-bit Windows, so download and install the 3rd file. If it’s running 64-bit Windows, download and install the 3rd file. (To see what type of Windows your system is running, right-click My Computer, select Properties, and look under System > System Type: XX-bit Operating System)

Once the SDK is installed, restart your computer. Then, go ahead and plug in your Kinect via USB. Confirm that its power adapter is plugged in. Windows should automatically install the drivers.

Troubleshooting: If MIT Kinect.exe doesn’t run, it’s because the Kinect is not recognized. To uninstall the drivers, unplug the Kinect and go to the Device Manager (right-click My Computer > Device Manager). Under Microsoft Kinect, there should be 3 devices (Microsoft Kinect Audio Array Controller, Microsoft Kinect Camera, Microsoft Kinect Device). Right-click on each and uninstall them. Unplug the Kinect. Restart your computer. Plug the Kinect in and let Windows recognize the drivers.

Features
---------------
Calibration: calibration is necessary before interacting with the MIT. 

•	Make sure the user is recognized. The screen will turn color when the user is recognized.

•	Have the user keep their hands a little higher than as low as they can go, and hit Calibrate. After 5 seconds, the application will sample where the user’s hands were, and will use that height as a baseline.

Absolute Tolerance: the tolerance region is the same height no matter where the hands are. Tolerance value indicates this height, and green-to-yellow and yellow-to-red distances indicate the height of the interpolation between these colors.

Proportional Tolerance: the tolerance region’s boundaries are set ratio values. Tolerance increases as the highest hand gets higher. Tolerance value specifies the proportion range that hands’ ratio values at any given time can move through, still keeping the screen green.

Smoothing: the smoothing algorithm implemented is Holt Double Exponential Smoothing (http://en.wikipedia.org/wiki/Exponential_smoothing). 

•	data smoothing rate: smooths the observations. The higher the number, the faster the dampening and the more weight given to recent observations.

•	trend smoothing rate: smooths the trends. High values predict trends more, and tend to overshoot actual hand positions.

•	Trend extrapolation / sensitivity constant: changes the amount at which trends are predicted or exaggerated. Can also be thought of as sensitivity (if = 100, a small movement will move the crosshairs really fast)


Skeletal Viewer
---------------
If you want to look at a tracked skeleton (for instance, to make sure user is wearing the right kind of clothing, to make sure user is in the frame), open Skeletal Viewer. Note that MIT for Kinect and Skeletal Viewer cannot be open at the same time!
