using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;

public class ControlInputs : MonoBehaviour {

    public static Action<float> Speed;
    public static Action<float> Direction;


	// Use this for initialization
	void Start () {
        StartCoroutine(TheMover());
    }

    // Update is called once per frame
    IEnumerator TheMover() {

        
        while (true)
        {
            yield return null;

            if (Input.GetKey(KeyCode.LeftArrow) && Direction != null)
            {
                Direction(180);
            }
            if (Input.GetKey(KeyCode.RightArrow) && Direction != null)
            {
                Direction(0);
            }
            if (Input.GetKey(KeyCode.UpArrow) && Direction != null)
            {
                Direction(90);
            }
            if (Input.GetKey(KeyCode.DownArrow) && Direction != null)
            {
                Direction(270);
            }

        }
       
    }

}
