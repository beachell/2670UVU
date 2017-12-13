using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTestErase : MonoBehaviour {

    public float speed= 5;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Mover());

    }

    IEnumerator Mover()
    {

        while (true)
        {
            yield return null;
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);

            if (Input.GetKeyDown(KeyCode.Space))
            {
              //  CharacterControllerScript.MoveCharacter += Jumper;
            }
        }

    }

    public void Jumper()
    {

    }
}


