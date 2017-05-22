using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
	private float seincivilidad = 2f;
	private float rotacionEnX;
	private float rotacionEnY;

	void Start(){
		rotacionEnY = transform.rotation.y;
	}

	void Update () {

		rotacionEnX +=  Input.GetAxis ("Mouse Y") * seincivilidad;
		rotacionEnY -=  Input.GetAxis ("Mouse X") * seincivilidad;

		transform.parent.transform.rotation = Quaternion.Euler (0f, -rotacionEnY-90, 0f);
		transform.rotation = Quaternion.Euler (-rotacionEnX, -rotacionEnY, 0f);
	}
}
