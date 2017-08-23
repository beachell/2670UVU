using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScriptSphere : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
        print("Sphere- please leave");
	}
	
	// Update is called once per frame
	void OnTriggerExit () {
        print("Sphere- Fine I didn't like you anyways");
	}
}
