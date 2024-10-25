using System;
using System.Collections;
using System.Collections.Generic;
using Entity;
using UnityEngine;
using UnityEngine.Serialization;

public class ProjectileManager : MonoBehaviour
{   
    public GameObject pObject;      //Object to be launched
    public int amount;              //Amount of arrows left
    public float fullLaunchDelay;   //Time to press for full speed launch
    public float ld;                //Actual time held for launch
    
    
    private Inventory _inventory;   //Inventory to check for the presence of items
    private bool _equipped;         //Is an arrow about to be shot ?
    private bool _launched;         //Was the arrow launched ?

    
    void Start() {
        _inventory = this.GetComponent<Inventory>();

        //Only if player has no arrows on startup
       /* if (amount <= 0) {
            throw new ArgumentException("Arrow amount is lower than 1!");
        }*/

        /*if (_inventory.slots.Count == 0)
        {
            Debug.Log("Empty inventory!");
        }*/
    }
    
    //Create instance of projectile when button is pressed
    public void StartLaunchProc() {
        if (_equipped || _inventory.IsEmpty()) {
            Debug.Log("No arrows Left to shoot!");
        }
        else {
             pObject = Instantiate(pObject, transform.position, transform.rotation, this.transform);
             Debug.Log($"Object {pObject} instantiated");
             _equipped = true;
             amount--;
        }
    }
    
    public void LaunchProjectile() {
        //Launches arrow at a fraction of launchSpeed, det. by % of time with btn held
        float normalizedLaunchSpeed = (ld / fullLaunchDelay) * pObject.GetComponent<Arrow>().launchSpeed;
        pObject.GetComponent<Arrow>().Launch(normalizedLaunchSpeed);
        _equipped = false;
    }

    public void Reset()
    {
        ld = 0;
    }
}
