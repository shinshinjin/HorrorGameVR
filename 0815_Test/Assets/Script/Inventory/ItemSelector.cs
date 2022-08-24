using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
    //public Slot[] slots;

    private Slot _slot;

    public void OnClickButton()
    {
        _slot = GetComponent<Slot>();
        ItemManager.Instance.isSelected[_slot.SlotIndex] = true;
        if (_slot.ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(_slot.ItemName);
            ItemManager.Instance.CurrentItemName = _slot.ItemName;
            ItemManager.Instance.CurrentSlot = _slot;
        }
    }
    
}
