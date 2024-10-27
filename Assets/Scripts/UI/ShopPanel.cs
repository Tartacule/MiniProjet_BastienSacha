using Player;
using UnityEngine;


public class ShopPanel : MonoBehaviour
{
    public Shop shop;
    public ArticlePanel panel;
    
    private void OnEnable()
    {
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

        foreach (ShopItem item in shop.shopList) {
            ArticlePanel ap = Instantiate(panel, this.transform); //Create a new panel
            ap.SetPanelData(item); //Set all essential data
            ap.index = i; //Dynamically give indexes to each one

            i++;
        }
    }
}

