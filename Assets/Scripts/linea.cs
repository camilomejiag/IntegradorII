using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linea : MonoBehaviour {
	public int lineas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)  {
		if(col.gameObject.tag == "hero" && lineas == 0){
			SpawnArmas.instancia.center++;
		}

		if(col.gameObject.tag == "hero" && lineas == 1){
			SpawnArmas.instancia.right++;
		}

		if(col.gameObject.tag == "hero" && lineas == 2){
			SpawnArmas.instancia.left++;
		}
	}
}
