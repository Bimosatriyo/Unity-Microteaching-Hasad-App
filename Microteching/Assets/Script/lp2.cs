using UnityEngine;
using System.Collections;

public class lp2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
}
	void OnGUI(){
		if(GUI.Button(new Rect(30,1150,210,80), "Back")) {
			Application.LoadLevel(21);
		}
		if(GUI.Button(new Rect(260,1150,210,80), "Menu")) {
			Application.LoadLevel(4);
		}	
	}
}