Drag and drop Prefabs/FrameRateCanvas prefab to your scene. If the text is not visible
in game view, select the FrameRateDisplay text component and drag it until it is in 
front of your camera. You can adjust the text properties like font, size, width, height etc. 
per your needs.

You can configure the FrameCounter script (it is attached to the FrameRateDisplay text component 
of the prefab) with the following variables:

Enable Min Fps: This enables displaying minimum frame rate seen so far
Enable Max Fps: This enables displaying the maximum frame rate seen so far

The current frame rate is always visible. Unit is frames per second.
