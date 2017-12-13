using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Networking;

public class TurretAIList : MonoBehaviour {

    ////Use this Codes for Turrets

    ///// <summary>
    ///// Brad Beachell
    ///// 
    ///// The goal of this script is to detect an intruder. when there is an intruder the turret will look at and shoot 
    ///// at the intruder. 
    ///// 
    ///// Must haves to make this work:
    ///// You must have an object like a sphere or cylinder object to put this script on. Scale it to the size of the
    ///// trigger area. Once you have it to the desired size you then turn off the mesh renderer and put the
    ///// turret head as a child of that cylinder. Set the area as a trigger
    ///// 
    ///// the targets need to have a rigidbody and a collider. 
    ///// </summary>
    ///// 

    ////ben's--------------
    //public Rigidbody currentBullet;
    //public float bulletSpeed;

    ////chris
    //public float shootWait = 0.1f;
    //public Transform shootPosition;
    ////----------------------
    //Animator anim;
    //bool IsFiring = false;
    //public Transform rootObj;
    //List<GameObject> targetDinosaurs = new List<GameObject>();
    //public float smoothValue = 5;

    //private void Start()
    //{
    //    anim = GetComponentInChildren<Animator>();
    //}

    //public void OnTriggerEnter(Collider Target)
    //{
    //    targetDinosaurs.Add(Target.gameObject);
    //    if(targetDinosaurs.Count == 1)
    //        StartCoroutine(TargetingSystem());

    //    IsFiring = true;
    //    anim.SetBool("IsFiring", IsFiring);

    //}


    //public void OnTriggerExit(Collider Target)
    //{
    //    targetDinosaurs.Remove(Target.gameObject);
        
    //    if(targetDinosaurs.Count == 0)
    //        StopAllCoroutines();
    //    IsFiring = false;
    //    anim.SetBool("IsFiring", IsFiring);
    //}

    //IEnumerator TargetingSystem()
    //{
    //    float lastShootTime = -shootWait;
    //    while (true)
    //    {
    //        //Vector3 direction = targetDinosaurs[0].transform.position; // Check this transform
    //        //rootObj.rotation = Quaternion.Slerp(rootObj.rotation, Quaternion.LookRotation(direction, Vector3.up), smoothValue * Time.deltaTime);//this was made by chris
    //        //yield return null;
            
           
    //        Vector3 direction = targetDinosaurs[0].transform.position - transform.position; // Check this transform
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction, Vector3.up), smoothValue * Time.deltaTime);
    //        yield return null;
    //       // yield return new WaitForSeconds(1);         
    //        //-------------------------------------
    //        if (Time.time - lastShootTime >= shootWait)
    //        {
    //            lastShootTime = Time.time;
    //           ShooterHandler();
    //        }
    //        //---------------------------------------
    //    }       
    //}
    ////------------------------------------Not my code
    //public void ShooterHandler()
    //{       
    //    //if (!BulletPool.shooting)
    //    //{
    //    if (BulletPool.bullets.Count > 0)
    //    {
    //        currentBullet = BulletPool.bullets[0];
    //        currentBullet.GetComponent<Bullet>().TimeOutStarter();
    //        BulletPool.bullets.Remove(currentBullet);
    //        currentBullet.transform.position = shootPosition.position;
    //        currentBullet.transform.rotation = shootPosition.rotation;
    //        currentBullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bulletSpeed, ForceMode.VelocityChange);
    //    }
    //}//-----------------------------------

}
/// to use a remove from an object from a list use 

///attack targetDinosaurs[0] always;

///lookat.targetDinosaurs[0]


//be sure to have an empty game object pointing straight out for the firing of bullets.
//take the firing script and put it into its own but operate like the turret list script. then add a invisible block so that what ever tartget 


//https://unity3d.com/learn/tutorials/topics/animation/animator-scripting?playlist=17099 for the animaton controller scripting. 














