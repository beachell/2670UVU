using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    
    public float speed = 3;
    public Transform shotSpawn;
    public Transform bulletPool;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        StartCoroutine(MoveBullet());
        rb = GetComponent<Rigidbody>();
    }

    IEnumerator MoveBullet() {
        yield return null;
        while (true)
        {
            //put the movement for the bullet
           
            rb.AddForce(transform.forward*speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.transform.position = bulletPool.position;
        OnDisable();
    }

    private void OnDisable()
    {
        rb.Sleep();
    }

}
//https://unity3d.com/learn/tutorials/topics/scripting/creating-use-action