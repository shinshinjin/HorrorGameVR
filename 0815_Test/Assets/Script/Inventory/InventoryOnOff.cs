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
    }
}
