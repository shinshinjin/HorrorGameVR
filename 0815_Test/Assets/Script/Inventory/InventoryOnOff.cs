using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOnOff : MonoBehaviour
{
    public UserInput _input;

    public GameObject Inventory;

    public NumberCofferInteraction Coffer;

    private void Start()
    {
        Inventory.SetActive(false);
    }
    public void InventoryOnOffFunc()
    {
        Inventory.SetActive(_input.IsInventoryOn);
        if (_input.IsPauseOn == false && _input.IsInventoryOn == false && GameManager.Instance.IsCofferOn == false)
        {
            GameManager.Instance.IsMouseLocked = true;
            GameManager.Instance.IsPaused = false;
        }
        else
        {
            GameManager.Instance.IsMouseLocked = false;
            GameManager.Instance.IsPaused = true;
        }
    }
}
