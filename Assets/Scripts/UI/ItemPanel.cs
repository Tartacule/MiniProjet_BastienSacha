using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    private Item _item;
    
    public Image img;
    public TMP_Text itemName;
    public TMP_Text itemDesc;
    public TMP_Text itemAmount;

    public void SetPanelData(Item item)
    {
        _item = item;
        img.sprite = item.SO_InvSlot.Icon;
        itemName.text = item.SO_InvSlot.Name;
        itemDesc.text = item.SO_InvSlot.Description;
        itemAmount.text = item.amount.ToString();
    }
}
