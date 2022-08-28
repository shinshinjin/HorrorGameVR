using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STOP : MonoBehaviour
{
    public GameObject _stopSound;
    public GameObject _Man;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _stopSound.SetActive(true);
            _Man.SetActive(false);
        }
    }
}
