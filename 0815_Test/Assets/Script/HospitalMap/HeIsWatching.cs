using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeIsWatching : MonoBehaviour
{
    public GameObject _Doctor;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _Doctor.SetActive(true);
        }
    }
}
