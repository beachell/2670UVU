using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{

    /*I am using script similar to the one I wrote for the juniors project, 
     * but due to it requiring a networking setup that we had to have someone else add because 
     * I don't know how to script for networking. I will be modifying it to work on a single player game.
    */

    public Rigidbody bullet;
    public float bulletSpeed;
    Animator anim;
    bool IsFiring = false;
    public Transform rootObj;
    List<GameObject> targetDinosaurs = new List<GameObject>();
    public float smoothValue = 5;
    public float shootWait;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider Target)
    {

        print("there  is a target");
        targetDinosaurs.Add(Target.gameObject);
        if (targetDinosaurs.Count == 1)
        {
            StartCoroutine(TargetingSystem());
            
        }
        IsFiring = true;
        anim.SetBool("IsFiring", IsFiring);
    }

    

    private void OnTriggerExit(Collider Target)
    {
        targetDinosaurs.Remove(Target.gameObject);
        if (targetDinosaurs.Count == 0)
        {
            StopAllCoroutines();
        }
        IsFiring = false;
        anim.SetBool("IsFiring", IsFiring);
    }
    IEnumerator TargetingSystem()
    {
        float lastShootTime = -shootWait;
        while (true)
        {
            Vector3 direction = targetDinosaurs[0].transform.position - transform.position; // Check this transform
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction, Vector3.up), smoothValue * Time.deltaTime);
            yield return null;
            print("moving");
            if (Time.time - lastShootTime >= shootWait)
            {
                lastShootTime = Time.time;
                Fire();
            }

        }
    }

    private void Fire()
    {
        print("I'm Shooting");
        
    }

}
