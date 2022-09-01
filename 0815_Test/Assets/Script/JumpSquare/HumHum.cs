using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumHum : MonoBehaviour
{
    public GameObject _sound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _sound.SetActive(true);
            gameObject.SetActive(false);
            Destroy(_sound, 10f);       
        }
    }
}
