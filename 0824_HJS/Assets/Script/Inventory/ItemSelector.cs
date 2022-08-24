using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
    public Slot[] slots;
    public void OnClickButton1()
    {
        ItemManager.Instance.isSelected[0] = true;
        if(slots[0].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[0].ItemName);
            ItemManager.Instance.CurrentItemName = slots[0].ItemName;
        }
    }
    public void OnClickButton2()
    {
        ItemManager.Instance.isSelected[1] = true;
        if (slots[1].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[1].ItemName);
            ItemManager.Instance.CurrentItemName = slots[1].ItemName;
        }
    }
    public void OnClickButton3()
    {
        ItemManager.Instance.isSelected[2] = true;
        if (slots[2].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[2].ItemName);
            ItemManager.Instance.CurrentItemName = slots[2].ItemName;
        }
    }
    public void OnClickButton4()
    {
        ItemManager.Instance.isSelected[3] = true;
        if (slots[3].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[3].ItemName);
            ItemManager.Instance.CurrentItemName = slots[3].ItemName;
        }
    }
    public void OnClickButton5()
    {
        ItemManager.Instance.isSelected[4] = true;
        if (slots[4].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[4].ItemName);
            ItemManager.Instance.CurrentItemName = slots[4].ItemName;
        }
    }
    public void OnClickButton6()
    {
        ItemManager.Instance.isSelected[5] = true;
        if (slots[5].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[5].ItemName);
            ItemManager.Instance.CurrentItemName = slots[5].ItemName;
        }
    }
    public void OnClickButton7()
    {
        ItemManager.Instance.isSelected[6] = true;
        if (slots[6].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[6].ItemName);
            ItemManager.Instance.CurrentItemName = slots[6].ItemName;
        }
    }
    public void OnClickButton8()
    {
        ItemManager.Instance.isSelected[7] = true;
        if (slots[7].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[7].ItemName);
            ItemManager.Instance.CurrentItemName = slots[7].ItemName;
        }
    }
    public void OnClickButton9()
    {
        ItemManager.Instance.isSelected[8] = true;
        if (slots[8].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[8].ItemName);
            ItemManager.Instance.CurrentItemName = slots[8].ItemName;
        }
    }
    public void OnClickButton10()
    {
        ItemManager.Instance.isSelected[9] = true;
        if (slots[9].ItemName != null)
        {
            UIManager.Instance.SetSelectedItemText(slots[9].ItemName);
            ItemManager.Instance.CurrentItemName = slots[9].ItemName;
        }
    }
}
