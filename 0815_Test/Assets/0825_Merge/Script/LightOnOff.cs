using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    [SerializeField]
    GameObject _switch;

    [SerializeField]
    GameObject _switch_Off;

    [SerializeField]
    GameObject _Light;

    private bool IsLightOn;

    private void OnMouseDown()
    {
        if (IsLightOn == false)
        {
            Debug.Log("ºÒÄÑÁü");
            _switch.SetActive(true);
            _Light.gameObject.SetActive(true);
            IsLightOn = true;
            gameObject.SetActive(false);
        }

        else
        {
            Debug.Log("ºÒ²¨Áü");
            _switch_Off.SetActive(true);
            _Light.gameObject.SetActive(false);
            IsLightOn = false;
            gameObject.SetActive(false);
        }
    }
}
