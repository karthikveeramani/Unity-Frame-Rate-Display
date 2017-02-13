using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameCounter : MonoBehaviour {
	public bool enableMinFps = true;
	public bool enableMaxfps = true;
	private float fps;
	private float minFps = float.MaxValue;
	private float maxFps = float.MinValue;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		fps = 1 / Time.deltaTime;
		if (fps < minFps)
			minFps = fps;
		if (fps > maxFps)
			maxFps = fps;
		text.text = "FPS: " + fps.ToString("F0");
		if (enableMinFps)
			text.text += "\nMin FPS: " + minFps.ToString ("F0");
		if (enableMaxfps)
			text.text += "\nMax FPS: " + maxFps.ToString ("F0");
	}
}
