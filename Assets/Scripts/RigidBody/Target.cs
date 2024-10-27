using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public AudioSource FX;

    public void Start()
    {
        FX = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        FX.Play();
        Destroy(gameObject, 5f);
    }
    
}
