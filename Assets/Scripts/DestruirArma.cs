using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirArma : MonoBehaviour {
    public float Destruir;
    public static DestruirArma instancia;
	// Use this for initialization
	void Start () {
        instancia = this;
	}
	
	// Update is called once per frame
	void Update () {
		Destruir += Time.deltaTime;
		if (Destruir >= 10.01)
        {
            Destroy(gameObject);
        }
	}
}
