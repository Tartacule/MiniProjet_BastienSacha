using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Player
{
    [System.Serializable]
    public class Inventory : MonoBehaviour
    {
        public List<Item> itemList;
        
        public bool IsEmpty => itemList.Count == 0;   //Is the inventory empty ?
    }
    
}
