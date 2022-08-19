using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager _instance;

    public bool IsHaveKey { get; set; }
    public bool AlreadyHaveKey { get; set; }
    public bool IsHavePhone { get; set; }
    public bool AlreadyHavePhone { get; set; }

    public ItemData[] itemDatas;

    public bool[] isSelected;

    public static ItemManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ItemManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ResetSelect()
    {
        for(int i = 0; i < isSelected.Length; i++)
        {
            isSelected[i] = false;
        }
    }
}
