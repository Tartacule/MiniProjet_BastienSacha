using System.Collections.Generic;
using System.Linq;
using Player;
using UI;
using UnityEngine;

[System.Serializable]
// ReSharper disable once CheckNamespace
public class Shop : MonoBehaviour
{
    public List<ShopItem> shopList;
    public Inventory depositInventory;
    public InventoryPanel depositPanel;
    
    public bool IsEmpty => shopList.Count == 0;   //Is the inventory empty ?
    public bool IsFull => shopList.Count >= 5;    //Are there more than 5 items ?

    public void Purchase(ShopItem shopItem)
    {
        bool foundInInventory;
        
        //Check player's funds
        if (shopItem.price > depositInventory.currencyAmount)
        {
            Debug.Log($"Not enough funds");
            return;
        }
        
        //Check if inventory already contains item
        foreach (Item item in depositInventory.itemList)
        {
            if (item.SO_InvSlot.Name.Equals(shopItem.SO_ShpSlot.Name))
            {
                foundInInventory = true;
                item.amount++;
                depositInventory.currencyAmount -= shopItem.price;
                depositPanel.UpdateGUI();
                return;
            }
        }  
        depositInventory.itemList.Add(new Item(shopItem.SO_ShpSlot, 1));
        depositInventory.currencyAmount -= shopItem.price;
        depositPanel.UpdateGUI();
    }
}

