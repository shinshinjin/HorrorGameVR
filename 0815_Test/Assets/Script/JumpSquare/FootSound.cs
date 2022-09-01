using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSound : MonoBehaviour
{
    public GameObject _footsounders;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.SetActive(false);
            _footsounders.SetActive(true);
            Destroy(_footsounders, 7f);
        }
    }
}
