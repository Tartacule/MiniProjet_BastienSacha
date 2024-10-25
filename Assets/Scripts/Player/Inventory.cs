using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventorySlot> slots;

    public bool IsEmpty()
    {
        return (slots.Count == 0) ? true : false;
    }
}
