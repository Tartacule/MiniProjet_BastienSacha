using Player;
using UnityEngine;

namespace UI
{
    public class InventoryPanel : MonoBehaviour
    {
        public Inventory inventory;
        public ItemPanel panel;
        
        private void OnEnable() {
            UpdateGUI();
        }

        public void UpdateGUI() {
            inventory.RemoveEmptySlots();
            ClearGUI();
            PopulateGUI();
        }

        private void ClearGUI() {
            foreach (Transform childPanel in transform) {
                Debug.Log($"Removed {childPanel.name}");
                GameObject.Destroy(childPanel.gameObject);
            }
        }

        private void PopulateGUI() {
            int i = 0;
            
            foreach (Item item in inventory.itemList) {
                ItemPanel ip = Instantiate(panel, this.transform);  //Create a new panel
                ip.SetPanelData(item);                              //Set all essential data
                ip.index = i;                                       //Dynamically give indexes to each one

                i++;
            }
        }
    }
}


