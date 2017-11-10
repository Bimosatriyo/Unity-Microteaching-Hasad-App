using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI(){
		if(GUI.Button(new Rect(260,450,210,80), "Materi")) {
			Application.LoadLevel(5);
		}
		if(GUI.Button(new Rect(260,550,210,80), "Standar Kopetensi")) {
			Application.LoadLevel(18);
		}
		if(GUI.Button(new Rect(260,650,210,80), "Peta Konsep")) {
			Application.LoadLevel(19);
		}
		if(GUI.Button(new Rect(260,750,210,80), "Kompetensi Dasar")) {
			Application.LoadLevel(20);
			}
		if(GUI.Button(new Rect(260,850,210,80), "Lesson Plan")) {
			Application.LoadLevel(21);
			}
		if(GUI.Button(new Rect(260,950,210,80), "Evaluasi")) {
			Application.LoadLevel(23);
			}
		if(GUI.Button(new Rect(260,1050,210,80), "Keluar")) {
			Application.Quit();
			}
	}
}