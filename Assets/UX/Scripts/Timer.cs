using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timer = 0.0f;
	private Text label;
	public static Timer instancia;
	void Start() {
		instancia = this;
		label = GetComponent<Text> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime;
		label.text = TimerFormat(timer);
		Debug.Log ("Time: " + timer.ToString());
	}

	private string TimerFormat(float sec){
		return Mathf.Floor(sec/60).ToString("00") + ":" + (sec % 60).ToString("00")
			+ ":" + ((sec*100)%100).ToString("00");
	}
}
