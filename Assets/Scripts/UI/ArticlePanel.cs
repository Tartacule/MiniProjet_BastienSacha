using System.Collections;
using System.Collections.Generic;
using Entity;
using Player;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ArticlePanel : MonoBehaviour
{
    private Shop _shop;

    private ShopItem _item;

    public Image img;
    public TMP_Text itemName;
    public TMP_Text itemDesc;
    public TMP_Text itemPrice;
    public Button BuyButton;
    public int index;

    public void SetPanelData(Shop shop, ShopItem item)
    {
        _shop = shop;
        _item = item;
        img.sprite = item.SO_ShpSlot.Icon;
        itemName.text = item.SO_ShpSlot.Name;
        itemDesc.text = item.SO_ShpSlot.Description;
        itemPrice.text = item.price.ToString();
        //BuyButton is assigned through the editor
    }

    public void Buy()
    {
        Debug.Log("Buy");
        _shop.Purchase(_item);
    }
}
