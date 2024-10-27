using Player;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    private Inventory _inventory;
    
    private Item _item;
    
    public Image img;
    public TMP_Text itemName;
    public TMP_Text itemDesc;
    public TMP_Text itemAmount;
    public Button selectButton;
    public int index;
   
    public void SetPanelData(Item item) {
        _inventory = transform.parent.GetComponent<InventoryPanel>().inventory;
        _item = item;
        img.sprite = item.SO_InvSlot.Icon;
        itemName.text = item.SO_InvSlot.Name;
        itemDesc.text = item.SO_InvSlot.Description;
        itemAmount.text = item.amount.ToString();
        selectButton = this.GetComponent<Button>();
    }

    public void SetSelected() {
        _inventory.selected = index;
    }
}
