using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPuzzleKeyBoardInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;
    public int _screenIndex;

    public BeamProjectInteraction Beam;

    public GameObject[] Screens;

    private AudioSource _audioSource;
    private int _currentScreenIndex;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
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
            _activeText = "먼저, 빔 프로젝트를 켜자";
        }
    }
    public void Interaction()
    {
        _audioSource.Play();
        if (Beam._isBeamOn)
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
