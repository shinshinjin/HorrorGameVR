using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonitorInteraction : MonoBehaviour, IInteraction
{
    public UnityEvent InteractMonitor;
    public string _activeText;

    [SerializeField]
    private GameObject[] _screen;
    public bool _isScreenOn;

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
                _screen[0].SetActive(false);
            }
            _isScreenOn = false;
        }
        else
        {
            for (int i = 0; i < _screen.Length; i++)
            {
                _screen[0].SetActive(true);
            }
            _isScreenOn = true;
        }
        InteractMonitor.Invoke();
    }
}
