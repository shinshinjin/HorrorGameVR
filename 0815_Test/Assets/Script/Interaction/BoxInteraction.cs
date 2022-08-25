using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour, IInteraction
{
    public GameObject[] _gameObject;

    public string _activeText;

    private void Awake()
    {
        _activeText = "�ڽ� ������";
    }

    public void Interaction()
    {
        Debug.Log("�������ȴ�...");
        _gameObject[0].SetActive(true);
        _gameObject[1].SetActive(false);
    }
}
