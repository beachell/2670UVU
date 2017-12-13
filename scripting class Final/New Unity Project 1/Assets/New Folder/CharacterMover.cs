using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour {
    public float speed = 5;
     Vector3 DirectionMoving;
    CharacterController myController;

	// Use this for initialization
	void Start () {
        CanPlayHandler();

	}
	
	// Update is called once per frame
	void CanPlayHandler () {
        myController = GetComponent<CharacterController>();
        ControlInputs.Speed += MoveCharacter;
        
	}
    void MoveCharacter(float _speed) {
        if (myController.isGrounded)
        {
            DirectionMoving.x = _speed * speed;
            DirectionMoving.z = _speed * speed;
            DirectionMoving.y = 0;
        }
        myController.Move(DirectionMoving * Time.deltaTime);
    }
}
