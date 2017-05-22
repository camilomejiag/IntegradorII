using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mover : MonoBehaviour {

	private Rigidbody cuerpo;
	public float velociadad;
	public float fuerza;
	public string movimientos;
	private int cont;
	public Image gano;
	public Image perdio;
	public GameObject inicio;
	// Use this for initialization
	void Start () {
		cuerpo = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			cuerpo.AddRelativeForce (velociadad,0f,0f);
		}
		if(Input.GetKey("s")){
			cuerpo.AddRelativeForce (-velociadad,0f,0f);
		}
		if(Input.GetKey("a")){
			cuerpo.AddRelativeForce (0f,0f,velociadad);
		}
		if(Input.GetKey("d")){
			cuerpo.AddRelativeForce (0f,0f,-velociadad);
		}

		if(Input.GetKey("space") && cont < 1){
			cuerpo.AddForce (0f,fuerza,0f);
			cont++;
		}

		if(Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d")){
			cuerpo.velocity = Vector3.zero;
			cuerpo.angularVelocity = Vector3.zero;
		}
	}

	public void repetir(){
		Timer.instancia.timer = 0.0f;
		Time.timeScale = 1;
		perdio.gameObject.SetActive (false);
		gano.gameObject.SetActive (false);
		gameObject.transform.position = inicio.transform.position;

	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "terreno"){
			cont = 0;
		}

		if(collision.gameObject.tag == "trampa"){
			perdio.gameObject.SetActive (true);
			Time.timeScale = 0;
		}

		if(collision.gameObject.tag == "win"){
			gano.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
