using System.Collections;
using System.Collections.Generic;
using Player;
using TMPro;
using UnityEngine;

public class CurrencyPanel : MonoBehaviour
{
    public Inventory inventory;
    public TMP_Text currencyText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currencyText.text = inventory.currencyAmount.ToString();
    }
}
