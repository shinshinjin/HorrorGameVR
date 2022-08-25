using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;

    [SerializeField]
    private GameObject[] _screen;
    private bool _isScreenOn;

    private void Awake()
    {
        _activeText = "����� �ѱ�";
    }
    private void Update()
    {
        if (_isScreenOn)
        {
            _activeText = "����� ����";
        }
        else
        {
            _activeText = "����� �ѱ�";
        }
    }
    public void Interaction()
    {
        if (_isScreenOn)
        {
            for (int i = 0; i < _screen.Length; i++)
            {
                _screen[i].SetActive(false);
            }
            _isScreenOn = false;
        }
        else
        {
            for (int i = 0; i < _screen.Length; i++)
            {
                _screen[i].SetActive(true);
            }
            _isScreenOn = true;
        }
    }
}
