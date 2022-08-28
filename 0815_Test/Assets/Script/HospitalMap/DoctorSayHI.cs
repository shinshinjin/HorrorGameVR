using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorSayHI : MonoBehaviour
{
    public GameObject[] _gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _gameObject[0].SetActive(true);
            _gameObject[1].SetActive(true);
            gameObject.SetActive(false);
            Destroy(_gameObject[1], 5f);
        }
    }
}
