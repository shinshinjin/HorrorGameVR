using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    public GameObject[] _gameObject;

    public string _activeText;

    private void Awake()
    {
        _activeText = "����ġ�� �������";
    }

    public void Interaction()
    {
        if (ItemManager.Instance.CurrentItemName == "���� ����ġ")
        {
            _gameObject[0].SetActive(false);
            _gameObject[1].SetActive(true);
            _gameObject[2].SetActive(false);
        }
    }
}
