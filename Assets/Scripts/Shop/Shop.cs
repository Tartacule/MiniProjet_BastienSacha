using System;
using System.Collections.Generic;
using Entity;
using Player;
using UnityEngine;


[System.Serializable]
public class Shop : MonoBehaviour
{
    public List<ShopItem> shopList;
    public Inventory depositInventory;
    
    public bool IsEmpty => shopList.Count == 0;   //Is the inventory empty ?
    public bool IsFull => shopList.Count >= 5;    //Are there more than 5 items ?

    public void Purchase(ShopItem shopItem)
    {
        if (depositInventory.currencyAmount < shopItem.price)
        {
            Debug.Log("Insufficient funds!");
            return;
        }
        
        depositInventory.itemList.Add(new Item(shopItem.SO_ShpSlot, 1));
    }
}

