using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMaking : MonoBehaviour
{
    public GameObject _Shadow;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _Shadow.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
