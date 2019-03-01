using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour {
	public GUIStyle textStyle;
	public bool toggle_diff;
	public static bool toggle_music;
	void Start(){
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
	void OnGUI(){
		GUI.Box(new Rect(Screen.width/4-225,Screen.height/4-75, 250, 300), "Main Menu");
		if (GUI.Button(new Rect(Screen.width/4-175,Screen.height/4-25,150, 40), "Play Game")){
			SceneManager.LoadScene(1);
		}
		toggle_diff = (GUI.Toggle(new Rect(Screen.width/4-175,Screen.height/4+45,150, 40), toggle_diff, "Hard Mode"));

		toggle_music = (GUI.Toggle(new Rect(Screen.width/4-175,Screen.height/4+95,150, 40), toggle_music, "Music On/Off"));	
	}
}
