using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearAI : MonoBehaviour
{
    [SerializeField]
    GameObject _Door;

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Doctor")
        {
            other.gameObject.SetActive(false);
        }
        gameObject.SetActive(false);
        _Door.SetActive(true);
    }
}
