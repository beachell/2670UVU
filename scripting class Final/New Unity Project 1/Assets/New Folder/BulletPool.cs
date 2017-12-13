using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[CreateAssetMenu]
public class BulletPool : MonoBehaviour {

    public float fireRate = 1;
    public GameObject bullet;
    public int bulletPool = 10;
    List<GameObject> bullets;
    //public bool growList = true;

    private void Start()
    {
        bullets = new List<GameObject>();


        for (int i = 0; i < bulletPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet);
            obj.SetActive(false);
            bullets.Add(obj);
        }
        InvokeRepeating("Fire", fireRate, fireRate);
    }
    private void Fire()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                bullets[i].transform.position = transform.position;
                bullets[i].transform.rotation = transform.rotation;
                bullets[i].SetActive(true);
                break;
            }
        }
    }

}
//https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/scriptable-objects