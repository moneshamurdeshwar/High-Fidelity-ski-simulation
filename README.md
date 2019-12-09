# High-Fidelity-ski-simulation
Our high-fidelity skiing simulation runs on the HTC Vive and can be used with either a Vive controller or an HTC Vive Tracker. During runtime, it is also possible to dynamically switch which input source you wish to use by following the directions indicated below.  

## Instructions for Use with Controller(s)
1. Click on "Camera Rig" in the hierarchy, find the Movement script in the Inspector, and uncheck "Using Tracker."
2. Grab one or two Vive controllers, put on the headset, and press play.
3. To play, look in the direction you wish to travel and press forward on the touchpad of either controller to apply a force in that direction. If you get stuck in the snow, try looking around in different directions while pressing forward to wiggle out.
4. Enjoy!

## Instructions for Use with Tracker
1. Plug in the Tracker's USB and turn it in.
2. Determine the device index that Steam has assigned to the Tracker. To do this easily, navigate to CameraRig > Tracker and click on it so it shows up in the hierarchy. Find the SteamVR_Tracked_Object script and locate the field marked Index. Run the simulation. While holding up the tracker and tilting it around, click through the available indices, watching the console output (the angle of the tracker) to see which one corresponds with the tracker movement. Once you have identified the tracker, leave this index selected.
4. Click on "Camera Rig" in the hierarchy, find the Movement script in the Inspector, and check "Using Tracker."
5. To play, look in the direction you wish to travel and lean forward some amount to apply a corresponding force in that direction. If you get stuck in the snow, try looking around in different directions while leaning forward to wiggle out.
6. Enjoy!


