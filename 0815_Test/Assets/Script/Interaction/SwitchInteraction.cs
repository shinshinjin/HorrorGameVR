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
        _activeText = "����ġ ��ȣ�ۿ�";
    }

    public void Interaction()
    {
        if (IsLightOn == false)
        {
            IsLightOn = true;
            //Debug.Log($"����ġ : {IsLightOn}");
            _gameObject[0].SetActive(true);
            _gameObject[1].SetActive(false);
            _gameObject[2].SetActive(true);
        }

        else if (IsLightOn == true)
        {
            IsLightOn = false;
            //Debug.Log($"����ġ : {IsLightOn}");
            _gameObject[0].SetActive(false);
            _gameObject[1].SetActive(true);
            _gameObject[2].SetActive(false);
        }
    }
}
