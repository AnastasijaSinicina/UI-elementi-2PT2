using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varda_paradisana : MonoBehaviour {

    // Use this for initialization
    public int kadruSk = 0;
    void Start () {
		
    Debug.Log("Uzsakta programma! Tu esi " + kadruSk + " kadra.");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Kadrs " + kadruSk);
	}
}
