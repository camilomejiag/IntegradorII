using UnityEngine;
using System.Collections;
using EvomazeLibraryBuild;//INCLUDE LIBRARY-----

public class Evomaze_Ex : MonoBehaviour {

    /**
     * MOVETYPE PROFILES:
     * 1. FORWARD TENDENCY
     * 2. RIGHT TENDENCY
     * 3. LEFT TENDENCY
     * 4. ALT. FORWARD AND RIGHT TENDENCY
     * 5. ALT. FORWARD AND LEFT TENDENCY
     * 6. ALT. RIGHT AND LEFT TENDENCY
     * 
     * ACTIONTYPE PROFILES
     * 1.JUMPER
     * 2.NOT JUMPER
     **/

    MovementNetwork MoveType = new MovementNetwork(); //INSTANTIATE MOVEMENT NETWORK 
    ActionNetwork ActionType = new ActionNetwork(); //INSTANTIATE ACTION NETWORK

    double[] movements = new double[3];
    double[] actions = new double[4];





	// Use this for initialization
	void Start () {
        movements[0] = 36; //FORWARD
        movements[1] = 28; //RIGHT
        movements[2] = 22; //LEFT

        actions[0] = movements[0]; //FORWARD
        actions[1] = movements[1]; //RIGHT
        actions[2] = movements[2]; //LEFT
        actions[3] = 34; //JUMP

        Debug.Log(MoveType.Classify(movements)); //CLASSIFY MOVEMENT TENDANCIES 
        Debug.Log(ActionType.Classify(actions)); //CLASSIFY ACTION TENDANCIES 
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
