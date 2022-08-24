using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOnOff : MonoBehaviour
{
    public UserInput _input;

    public GameObject Inventory;

    private void Update()
    {
        Inventory.SetActive(_input.IsInventoryOn);
        if(_input.IsInventoryOn)
        {
            GameManager.Instance.IsMouseLocked = false;
            GameManager.Instance.IsPaused = true;
        }
        else
        {
            GameManager.Instance.IsMouseLocked = true;
            GameManager.Instance.IsPaused = false;
        }
    }
}
