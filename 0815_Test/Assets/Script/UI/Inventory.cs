using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // �κ��丮�� Ȱ��ȭ ��Ű�� true, �ٸ� �ൿ ����, i ������ ���� �ִ� 
    public static bool inventoryActivated = false;

    // �ʿ��� ������Ʈ
    [SerializeField]
    private GameObject go_InventoryBase;
    [SerializeField]
    private GameObject go_SlotsParent;

    // ���Ե�
    private Slot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        // �� �迭�ȿ� ���Ե��� �� ��.
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        TryOpenInventory();
    }

    private void TryOpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryActivated = !inventoryActivated;

            if (inventoryActivated)
            {
                OpenInventory();
            }
            else
            {
                CloseInventory();
            }
        }
    }

    private void OpenInventory()
    {
        go_InventoryBase.SetActive(true);
    }

    private void CloseInventory()
    {
        go_InventoryBase.SetActive(false);
    }

    internal void AcquireItem(bool v)
    {
        throw new NotImplementedException();
    }

    public void AcquireItem(Item _item, int _count = 1)
    {
        // ȹ���Ѱ� ����� �͵��̸� 
        if (Item.ItemType.Used != _item.itemType)
        {
            // �̹� �������� �ִٸ� ���� ����
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].item != null)
                {
                    if (slots[i].item.itemName == _item.itemName)
                    {
                        slots[i].SetSlotCount(_count);
                        return;
                    }
                }
            }
        }


        // �������� �����ٸ� ���ڸ��� ã�Ƽ� �־� �ش�.
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                if (slots[i].item.itemName == "")
                {
                    slots[i].AddItem(_item, _count);
                    return;
                }
            }
        }
    }
}
