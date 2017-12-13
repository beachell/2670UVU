using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OverheatDec : MonoBehaviour {
    public static Action overHeat;
    public int heatMax = 10;
    public int heatStart = 0;
    public static bool overHeated = false;
    //private void Awake()
    //{
    //    TurretShoot.TurretShooter += ShootHandler;
    //}

    private void ShootHandler()
    {
        print("Overheating is being called by turretAiList");
        StartCoroutine(CoolDown());
    }

    private void Start()
    {

        StartCoroutine(CoolDown());
        overHeat += GotClicked;

    }


    public void GotClicked()
    {

        //this will be replaced by being called from the character controller script later
        if (!overHeated)
        {
            // StartCoroutine(OverHeating());            
            HeatCheck();
        }


    }
   
    IEnumerator CoolDown()
    {
        if (true)
        {

            print("cooldown is running");
            if (heatStart > 0)
            {
                overHeated = true; heatStart--;
                print(heatStart + " cooldown count");
                //  StartCoroutine(OverHeating());
                GetComponent<Shoot>.enabled = true;
            }
            else overHeated = false;
            yield return new WaitForSeconds(1);
        }
    }


    //this increases the heat when it is called by the newheatcode coroutine. 
    //When it is overheated it changes the bool to true.
    public void HeatCheck()
    {
        if (heatStart < heatMax)
        {
            //insert shooting ref or script here.
            ShootHandler();

            heatStart++;
            print(heatStart + " Heating up");


        }
        else
        {
            overHeated = true;
            StartCoroutine(CoolDown());
            GetComponent<Shoot>.enabled = false;
        }
    }
}
