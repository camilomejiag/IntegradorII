using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EvomazeLibraryBuild;//INCLUDE LIBRARY----

public class SpawnArmas : MonoBehaviour {
    public int tipo;
	public int salta;
    public GameObject[] trampas;
    public bool change;
    public Vector3[] posiciones;
	public Vector3[] rotaciones;
    private Vector3 posI;
	public int cual;
	public int rot;
	public float tim;
	public int pos;
	public bool actvarC;
	public bool activarR;
	public bool activarI;

	//Inteligencia
	public int center, right, jump, left;

	MovementNetwork MoveType = new MovementNetwork(); //INSTANTIATE MOVEMENT NETWORK 
	ActionNetwork ActionType = new ActionNetwork(); //INSTANTIATE ACTION NETWORK

	double[] movements = new double[3];
	double[] actions = new double[4];

	public static SpawnArmas instancia;
	// Use this for initialization
	void Start () {
        change = true;
		posI = transform.localPosition;
		instancia = this;
	}
	
	// Update is called once per frame
	void Update () {
		tim += Time.deltaTime;
		if(tim >= 10){
			tipos ();
			tim = 0;
		}
        if (change) {
			gameObject.transform.localPosition = posI;
			gameObject.transform.localPosition += posiciones[pos];
            change = false;
			Instantiate(trampas[cual], gameObject.transform.position,Quaternion.Euler(rotaciones[rot]));// trampas[cual].gameObject.transform.rotation
 
        }

		if(center >= 90 || right >= 90 || left >= 90 ){
			center = center - 40;
			right = right - 40;
			left = left - 40;
		}
		movements[0] = center; //FORWARD
		movements[1] = right; //RIGHT
		movements[2] = left; //LEFT

		actions[0] = movements[0]; //FORWARD
		actions[1] = movements[1]; //RIGHT
		actions[2] = movements[2]; //LEFT
		actions[3] = jump; //JUMP

		tipo = MoveType.Classify(movements); //CLASSIFY MOVEMENT TENDANCIES 
		salta = ActionType.Classify(actions); //CLASSIFY ACTION TENDANCIES
	}
	void tipos(){
		int temp;
		int temp2;
		if (tipo == 1 || actvarC) {
			//spawn at center
			actvarC = false;
			temp = Random.Range(0,7);
			if(temp != 1 && temp != 6 || salta == 1){
				cual = temp;
				pos = temp + 7;
				temp2 = Random.Range(0,2);
				if(temp2 == 1 && temp == 0){
					rot = temp + 7;	
				}else{
					rot = temp;
				}
			} else {
				cual = 2;
				pos = 2;
				rot = 2;
			}
			change = true;
		}

		if (tipo == 2 || activarR) {
			//spawn at right
			activarR = false;
			temp = Random.Range(0,7);
			if(temp != 1 && temp != 2 && temp != 6 || salta == 1 && temp != 2){
				cual = temp;
				pos = temp;
				rot = temp;
			} else {
				cual = 5;
				pos = 5;
				rot = 5;
			}
			change = true;
		}

		if (tipo == 3 || activarI) {
			//spawn left
			activarI = false;
			temp = Random.Range(0,7);
			if (temp != 1 && temp != 2 && temp != 6 || salta == 1 && temp != 2) {
				cual = temp;
				pos = temp + 14;
				if (temp == 0) {
					rot = temp + 7;	
				} else {
					rot = temp;
				}

			} else {
				cual = 5;
				pos = 5 + 14;
				rot = 5;
			}
			change = true;
		}

		if (tipo == 4) {
			//center and right tendecy
			temp2 = Random.Range(0,2);
			if(temp2 == 1){
				activarR = true;
			}else{
				actvarC = true;
			}
		}

		if (tipo == 5) {
			//center and left tendency
			temp2 = Random.Range(0,2);
			if(temp2 == 1){
				actvarC = true;	
			}else{
				activarI = true;
			}
			change = true;
		}
	}	
}
