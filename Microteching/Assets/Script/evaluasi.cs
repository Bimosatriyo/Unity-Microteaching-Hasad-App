using UnityEngine;
using System.Collections;

public class evaluasi : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
}
	void OnGUI(){
		if(GUI.Button(new Rect(260,1150,210,80), "Menu")) {
			Application.LoadLevel(4);
		}	
	}
}