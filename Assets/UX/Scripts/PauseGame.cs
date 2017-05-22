using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	private bool pause = false;
	public GameObject pauseMenu;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)||
			Input.GetKeyDown(KeyCode.Escape)){
			pause = !pause;
			if (pause) {
				pauseGame ();
			} else {
				unpauseGame ();
			}
		}
	}

	private void pauseGame(){
		pauseMenu.SetActive (true);
		Time.timeScale = 0;
		Debug.Log ("Pause");
	}

	public void unpauseGame(){
		pauseMenu.SetActive (false);
		Time.timeScale = 1;
		Debug.Log ("Unpause");
	}
}
