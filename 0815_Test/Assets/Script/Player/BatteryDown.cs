using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDown : MonoBehaviour
{
    public GameObject _smartPhone;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _smartPhone.SetActive(false);
        }
    }
}
