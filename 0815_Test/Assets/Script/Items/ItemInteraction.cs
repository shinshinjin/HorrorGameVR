using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour , IInteraction
{
    public string ItemName { get; set; }

    public string _activeText;
    
    private void Awake()
    {
        _activeText = "������ ȹ���ϱ� (E)";
    }

    public void Interaction()
    {
        
        Debug.Assert(ItemName != null);
        if(ItemName == "Key")
        {
            ItemManager.Instance.IsHaveKey = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "SmartPhone")
        {
            ItemManager.Instance.IsHavePhone = true;
            gameObject.SetActive(false);
        }

        if(ItemName == "Tutorial_Key")
        {
            ItemManager.Instance.IsHaveTutorialKey = true;
            gameObject.SetActive(false);
        }

    }
}