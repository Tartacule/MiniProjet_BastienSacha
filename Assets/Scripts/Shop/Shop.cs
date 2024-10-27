using System.Collections.Generic;
using Player;
using UnityEngine;

[System.Serializable]
// ReSharper disable once CheckNamespace
public class Shop : MonoBehaviour
{
    public List<ShopItem> shopList;
    public Inventory depositInventory;
    
    public bool IsEmpty => shopList.Count == 0;   //Is the inventory empty ?
    public bool IsFull => shopList.Count >= 5;    //Are there more than 5 items ?

    public int Purchase(ShopItem shopItem)
    {
        Debug.Log("fuck");
        
        if (depositInventory.currencyAmount < shopItem.price)
        {
            Debug.Log("Insufficient funds!");
            return 0;
        }
        
        Debug.Log($"Purchased {shopItem}");
        depositInventory.itemList.Add(new Item(shopItem.SO_ShpSlot, 1));

        return 0;
    }
}

