using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    public GameObject[] _gameObject;

    public string _activeText;

    private void Awake()
    {
        _activeText = "스위치가 비어있음";
    }

    public void Interaction()
    {
        if (ItemManager.Instance.CurrentItemName == "전등 스위치")
        {
            _gameObject[0].SetActive(false);
            _gameObject[1].SetActive(true);
            _gameObject[2].SetActive(false);
        }
    }
}
