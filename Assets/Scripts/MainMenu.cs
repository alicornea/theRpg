using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public float guiPlacementY;
	public GUIStyle buttons;

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .25f, Screen.width * .5f, Screen.height * .1f), "", buttons)) {
			SceneManager.LoadScene("CreatePlayer");
		}

		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .5f, Screen.width * .5f, Screen.height * .1f), "Load Game")) {
		}

		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .75f, Screen.width * .5f, Screen.height * .1f), "Options")) {
		}
	}

}
