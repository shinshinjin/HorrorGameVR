using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPuzzleKeyBoardInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;
    public int _screenIndex;

    public BeamProjectInteraction _beam;

    public GameObject[] Screens;

    private int _currentScreenIndex;

    private void Awake()
    {
        _currentScreenIndex = 0;
        _activeText = "Q ��ư => ������ũ��    E ��ư => ������ũ��";
    }
    public void Interaction()
    {
        if(_beam._isBeamOn)
        {
            if (_screenIndex > 5)
            {
                _screenIndex = 0;
            }
            if (_screenIndex < 0)
            {
                _screenIndex = 5;
            }
            Screens[_currentScreenIndex].SetActive(false);
            Screens[_screenIndex].SetActive(true);
            _currentScreenIndex = _screenIndex;
        }
    }
}
