using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using ScriptableObjects;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UI
{
    public class InventoryPanel : MonoBehaviour
    {
        public Inventory inventory;
        public ItemPanel panel;

        private void Start() {
            PopulateGUI();
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }

        private void ClearGUI()
        {
            
        }

        private void PopulateGUI()
        {
            foreach (Item item in inventory.itemList)
            {
                ItemPanel ip = Instantiate(panel, this.transform);
                ip.SetPanelData(item);
            }
        }
        
    /*
        public List<GameObject> UpdateInventory()
        {
            return null;

        }*/
    }
}


