using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int _slotCount = 0;

    public Slot[] Slots;

    private void Update()
    {
        SetInventory();
    }

    public void SetInventory()
    {
        if(ItemManager.Instance.IsHaveKey)
        {
            Slots[0].ItemName = ItemManager.Instance.itemDatas[0].ItemName;
            Slots[0].ItemImage = ItemManager.Instance.itemDatas[0].ItemImage;
        }
        
    }
}
