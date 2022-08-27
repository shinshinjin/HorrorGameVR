using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerRoomLightOn : MonoBehaviour
{
    public GameObject _light;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _light.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
