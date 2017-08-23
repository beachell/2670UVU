using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
        print("I have entered");
	}
	
	// Update is called once per frame
	void OnTriggerExit () {
        print("I am leaving, you swine");
	}
}
