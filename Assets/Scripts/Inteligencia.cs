using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EvomazeLibraryBuild;//INCLUDE LIBRARY----

public class Inteligencia : MonoBehaviour {
	public int center, right, jump, left;

	public static Inteligencia instancia;
	MovementNetwork MoveType = new MovementNetwork(); //INSTANTIATE MOVEMENT NETWORK 
	ActionNetwork ActionType = new ActionNetwork(); //INSTANTIATE ACTION NETWORK

	double[] movements = new double[3];
	double[] actions = new double[4];
	// Use this for initialization
	void Start () {
		instancia = this;
	}
	
	// Update is called once per frame
	void Update () {
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

		SpawnArmas.instancia.tipo = MoveType.Classify(movements); //CLASSIFY MOVEMENT TENDANCIES 
		Debug.Log(SpawnArmas.instancia.tipo = MoveType.Classify(movements));
		SpawnArmas.instancia.salta = ActionType.Classify(actions); //CLASSIFY ACTION TENDANCIES 
	}
}
