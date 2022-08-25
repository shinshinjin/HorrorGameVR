using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private int _slotCount = 0;
    [SerializeField]
    private Slot[] Slots;
    [SerializeField]
    private Image _image;
    [SerializeField]
    private Sprite DefaultItemImage;

    private void Awake()
    {
        Slots = GetComponentsInChildren<Slot>();
        _image.sprite = DefaultItemImage;
    }
    private void Update()
    {
        SetInventory();
        DrawItemImage();
    }

    private void DrawItemImage()
    {
        if (ItemManager.Instance.CurrentSlot != null && ItemManager.Instance.isSelected[ItemManager.Instance.CurrentSlot.SlotIndex])
        {
            _image.sprite = ItemManager.Instance.CurrentSlot.ItemImage;
        }
        
        if(ItemManager.Instance.CurrentSlot != null && ItemManager.Instance.CurrentSlot._isItemIn == false)
        {
            _image.sprite = DefaultItemImage;
        }
        
    }
    public void SetInventory()
    {
        for(int i = 0; i < 10; i++)
        {
            if(Slots[i]._isItemIn == false)
            {
                _slotCount = i;
                break;
            }
        }

        if(ItemManager.Instance.IsHave11ClassKey && ItemManager.Instance.Already11ClassHaveKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[0].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[0].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.Already11ClassHaveKey = true;
        }

        if (ItemManager.Instance.IsHavePhone && ItemManager.Instance.AlreadyHavePhone == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[1].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[1].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHavePhone = true;
        }

        if (ItemManager.Instance.IsHaveTutorialKey && ItemManager.Instance.AlreadyHaveTutorialKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[2].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[2].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveTutorialKey = true;
        }

        if (ItemManager.Instance.IsHaveDriver && ItemManager.Instance.AlreadyHaveDriver == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[3].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[3].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveDriver = true;
        }

        if (ItemManager.Instance.IsHaveHammer && ItemManager.Instance.AlreadyHaveHammer == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[4].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[4].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveHammer = true;
        }

        if (ItemManager.Instance.IsHaveNoteBook && ItemManager.Instance.AlreadyHaveNoteBook == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[5].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[5].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveNoteBook = true;
        }

        if (ItemManager.Instance.IsHaveRingKey && ItemManager.Instance.AlreadyHaveRingKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[6].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[6].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveRingKey = true;
        }

        if (ItemManager.Instance.IsHave101Key && ItemManager.Instance.AlreadyHave101Key == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[7].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[7].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHave101Key = true;
        }

    }
}
