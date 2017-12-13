using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMover : MonoBehaviour {
    public float speed = 20;
    //// Use this for initialization
    //void Start () {
    //       StartCoroutine(BulletMove());
    //   }


    //   // Update is called once per frame
    //   IEnumerator BulletMove () {
    //       yield return new WaitForSeconds(0.5f);
    //       while (true)
    //       {
    //           transform.Translate(Vector3.forward * Time.deltaTime);
    //       }
    //}
    private void Update()
    {
        transform.Translate(Vector3.forward *speed* Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.SetActive(false);
    }
}
