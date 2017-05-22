using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class audio : MonoBehaviour {
	public AudioSource[] audios;
	public Image menu;
	public Image pausa;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			abrirM ();
		}
	}

	public void abrirM(){
		Time.timeScale = 0;
		pausa.gameObject.SetActive(true);
		audios [0].mute = true;
	}

	public void unPause(){
		Time.timeScale = 1;
		pausa.gameObject.SetActive(false);
		audios [0].mute = false;
	}

	public void cerrarM(){
		Time.timeScale = 1;
		menu.gameObject.SetActive(false);
		audios [0].Play ();
		audios [1].Stop ();
	}
}
