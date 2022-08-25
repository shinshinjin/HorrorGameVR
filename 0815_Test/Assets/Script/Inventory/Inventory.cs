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

        if (ItemManager.Instance.CurrentSlot != null && ItemManager.Instance.CurrentSlot._isItemIn == false)
        {
            _image.sprite = DefaultItemImage;
        }

    }
    public void SetInventory()
    {
        for (int i = 0; i < 10; i++)
        {
            if (Slots[i]._isItemIn == false)
            {
                _slotCount = i;
                break;
            }
        }

        if (ItemManager.Instance.IsHave11ClassKey && ItemManager.Instance.Already11ClassHaveKey == false)
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

        if (ItemManager.Instance.IsHaveLighter && ItemManager.Instance.AlreadyHaveLighter == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[8].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[8].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveLighter = true;
        }

        if (ItemManager.Instance.IsHaveScreenRemote && ItemManager.Instance.AlreadyHaveScreenRemote == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[9].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[9].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveScreenRemote = true;
        }

        if (ItemManager.Instance.IsHaveCCTV && ItemManager.Instance.AlreadyHaveCCTV == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[10].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[10].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveCCTV = true;
        }

        if (ItemManager.Instance.IsHave12ClassStorageKey && ItemManager.Instance.AlreadyHave12ClassStorageKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[11].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[11].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHave12ClassStorageKey = true;
        }

        if (ItemManager.Instance.IsHaveLightSwitch && ItemManager.Instance.AlreadyHaveLightSwitch == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[12].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[12].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveLightSwitch = true;
        }

        if (ItemManager.Instance.IsHaveBrain && ItemManager.Instance.AlreadyHaveBrain == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[13].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[13].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveBrain = true;
        }

        if (ItemManager.Instance.IsHaveScreenCofferKey && ItemManager.Instance.AlreadyHaveScreenCofferKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[14].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[14].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveScreenCofferKey = true;
        }

        if (ItemManager.Instance.IsHaveTherapyRoomKey && ItemManager.Instance.AlreadyHaveTherapyRoomKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[15].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[15].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveTherapyRoomKey = true;
        }

        if (ItemManager.Instance.IsHaveHospitalKey && ItemManager.Instance.AlreadyHaveHospitalKey == false)
        {
            Slots[_slotCount].ItemName = ItemManager.Instance.itemDatas[16].ItemName;
            Slots[_slotCount].ItemImage = ItemManager.Instance.itemDatas[16].ItemImage;
            Slots[_slotCount]._isItemIn = true;
            ItemManager.Instance.AlreadyHaveHospitalKey = true;
        }
    }
}