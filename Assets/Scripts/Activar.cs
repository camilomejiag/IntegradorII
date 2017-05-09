using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour {
	public Animator anima;
	public bool debug;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "hero"){
			anima.SetInteger ("mover",1);
			debug = true;
		}
	
	}
}
