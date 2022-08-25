using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteraction : MonoBehaviour, IInteraction
{
    public GameObject[] _gameObject;

    private bool IsLightOn = false;

    public string _activeText;

    private void Awake()
    {
        _activeText = "스위치 상호작용";
    }

    public void Interaction()
    {
        if (IsLightOn == false)
        {
            IsLightOn = true;
            //Debug.Log($"스위치 : {IsLightOn}");
            _gameObject[0].SetActive(true);
            _gameObject[1].SetActive(false);
            _gameObject[2].SetActive(true);
        }

        else if (IsLightOn == true)
        {
            IsLightOn = false;
            //Debug.Log($"스위치 : {IsLightOn}");
            _gameObject[0].SetActive(false);
            _gameObject[1].SetActive(true);
            _gameObject[2].SetActive(false);
        }
    }
}
