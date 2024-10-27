using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

[Serializable]
public class Item 
{
    public Slot SO_InvSlot;
    public int amount;

    public Item(Slot slot, int amt)
    {
        SO_InvSlot = slot;
        amount = amt;
    }
}
