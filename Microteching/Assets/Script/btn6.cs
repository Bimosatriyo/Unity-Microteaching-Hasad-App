﻿using UnityEngine;
using System.Collections;

public class btn6 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
}
	void OnGUI(){
		if(GUI.Button(new Rect(30,1150,210,80), "Back")) {
			Application.LoadLevel(10);
		}
		if(GUI.Button(new Rect(260,1150,210,80), "Menu")) {
			Application.LoadLevel(4);
		}
		if(GUI.Button(new Rect(480,1150,210,80), "Next")) {
			Application.LoadLevel(12);
		}	
	}
}