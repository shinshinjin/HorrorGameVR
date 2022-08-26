using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOff : MonoBehaviour
{
    public GameObject[] _gameObject;

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _gameObject[0].SetActive(false);
            _gameObject[1].SetActive(false);
        }
        gameObject.SetActive(false);
    }
}
