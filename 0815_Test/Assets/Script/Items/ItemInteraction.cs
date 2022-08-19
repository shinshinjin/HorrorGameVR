using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour , IInteraction
{
    public string ItemName { get; set; }

    public string _activeText;
    
    private void Awake()
    {
        _activeText = "æ∆¿Ã≈€ »πµÊ«œ±‚";
    }

    public void Interaction()
    {
        //for (int i = 0; i < ItemManager.Instance.itemDatas.Length; i++)
        //{
        //    if (ItemManager.Instance.itemDatas[i].ItemName == ItemName)
        //    {
        //    }
        //}
        //Slots[0].ItemData = ItemManager.Instance.itemDatas;

        

        Debug.Assert(ItemName != null);
        if(ItemName == "Key")
        {
            ItemManager.Instance.IsHaveKey = true;
            gameObject.SetActive(false);
        }

        
    }
}
