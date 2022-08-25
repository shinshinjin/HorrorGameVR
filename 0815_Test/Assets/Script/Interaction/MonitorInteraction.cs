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
        _activeText = "모니터 켜기";
    }
    private void Update()
    {
        if (_isScreenOn)
        {
            _activeText = "모니터 끄기";
        }
        else
        {
            _activeText = "모니터 켜기";
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
