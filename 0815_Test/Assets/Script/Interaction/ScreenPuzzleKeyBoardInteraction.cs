using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPuzzleKeyBoardInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;
    public int _screenIndex;

    public BeamProjectInteraction Beam;

    public GameObject[] Screens;

    private int _currentScreenIndex;

    private void Awake()
    {
        _currentScreenIndex = 0;
    }
    private void Update()
    {
        if(Beam._isBeamOn)
        {
            _activeText = "Q : Back  E : Next";
        }
        else
        {
            _activeText = "����, �� ������Ʈ�� ����";
        }
    }
    public void Interaction()
    {
        if(Beam._isBeamOn)
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
