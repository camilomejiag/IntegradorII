using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("a")){
			GetComponent<Rigidbody> ().velocity = new Vector3(2f,0f,0f);	
		}

	}
}
