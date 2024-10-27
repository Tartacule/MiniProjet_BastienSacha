using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Player
{
    [System.Serializable]
    public class Inventory : MonoBehaviour
    {
        public List<Item> itemList;
        
        public bool IsEmpty => itemList.Count == 0;     //Is the inventory empty ?
        public bool IsFull => itemList.Count >= 5;      //Are there more than 5 items ?
        public int selected;                            //ID of selected item to launch
        public int currencyAmount;                      //Amount of money left
        
        public void RemoveEmptySlots()
        {
            //Check for empty inventory slots
            foreach (Item item in itemList) {
                if (item.amount <= 0)
                    itemList.Remove(item);
            }
        }
    }
}
