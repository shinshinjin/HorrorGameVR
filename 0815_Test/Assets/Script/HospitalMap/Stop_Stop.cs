using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Stop : MonoBehaviour
{
    public GameObject[] _stopSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _stopSound[0].SetActive(false);
            _stopSound[1].SetActive(false);
            _stopSound[2].SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
