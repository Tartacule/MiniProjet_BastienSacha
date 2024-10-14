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
    
    private bool _equipped;         //Is an arrow about to be shot ?
    private Arrow _arrow;
    
    void Start()
    {
        _equipped = true;
        _arrow = pObject.GetComponent<Arrow>();

        //Only if player has no arrows on startup
        if (amount == 0)
        {
            throw new ArgumentException("No projectiles to shoot! Set a minimum amount to test.");
        }
    }

    void Update()
    {
        //Instantiate Proejctile if amount left is > 0
        if (amount <= 0)
        {
            Debug.Log("Projectile amount is zero!");
            _equipped = false;
        }
        
        if (Input.GetKeyDown(KeyCode.E)  && _equipped)
        {
            Instantiate(pObject, transform.position, transform.rotation, this.transform);
            Debug.Log($"Object {pObject} instantiated");
            amount--;
        }
    }
}
