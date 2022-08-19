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
        

        if(ItemManager.Instance.IsHaveKey && ItemManager.Instance.AlreadyHaveKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[0].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[0].ItemImage;
            ItemManager.Instance.AlreadyHaveKey = true;
            _slotCount++;
        }

        if (ItemManager.Instance.IsHavePhone && ItemManager.Instance.AlreadyHavePhone == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[1].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[1].ItemImage;
            ItemManager.Instance.AlreadyHavePhone = true;
            _slotCount++;
        }

    }
}
