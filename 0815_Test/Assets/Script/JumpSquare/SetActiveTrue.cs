using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveTrue : MonoBehaviour
{
    public GameObject _gameObject;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            _gameObject.SetActive(true);
            gameObject.SetActive(false);
            Destroy(_gameObject, 7f);
        }
    }
}
