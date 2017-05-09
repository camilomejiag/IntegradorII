using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {

	public float errorX = 0.5f, errorY = 0.5f, errorZ = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision) {
		GameObject obj = collision.gameObject;
		Rigidbody rb = collision.GetComponent <Rigidbody>();
		Vector3 dir = rb.velocity;//obj.transform.forward;
		Debug.Log("NEW PLANE");
		if (dir.x > errorX) {
			Debug.Log ("Positive X");
		} else if (dir.x < -errorX) {
			Debug.Log ("Negative X");
		}

		if (dir.y > errorY) {
			Debug.Log ("Positive Y");
		} else if (dir.y < -errorY) {
			Debug.Log ("Negative Y");
		}

		if (dir.z > errorZ) {
			Debug.Log ("Positive Z");
		} else if (dir.z < -errorZ){
			Debug.Log ("Negative Z");
		}
		Debug.Log("Direction: " + dir.x + "," + dir.y + "," + dir.z);
	}
}
