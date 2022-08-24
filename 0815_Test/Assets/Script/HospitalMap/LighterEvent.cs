using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterEvent : MonoBehaviour
{
    [SerializeField]
    GameObject Lighter;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Ǫ����!!!");
            Lighter.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
