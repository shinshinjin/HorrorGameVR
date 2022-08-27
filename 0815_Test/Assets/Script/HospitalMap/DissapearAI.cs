using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearAI : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Doctor")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
