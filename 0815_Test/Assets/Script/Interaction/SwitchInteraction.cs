using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteraction : MonoBehaviour, IInteraction
{
    public GameObject[] _gameObject;
    public AudioClip SwitchOn;
    public AudioClip SwitchOff;

    public string _activeText;

    private AudioSource _audioSource;

    private bool IsLightOn = false;


    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _activeText = "스위치 상호작용";
    }

    public void Interaction()
    {
        if (IsLightOn == false)
        {
            _audioSource.clip = SwitchOn;
            IsLightOn = true;
            _audioSource.Play();
            //Debug.Log($"스위치 : {IsLightOn}");
            _gameObject[0].SetActive(true);
            _gameObject[1].SetActive(false);
            _gameObject[2].SetActive(true);
        }

        else if (IsLightOn == true)
        {
            _audioSource.clip = SwitchOff;
            IsLightOn = false;
            _audioSource.Play();
            //Debug.Log($"스위치 : {IsLightOn}");
            _gameObject[0].SetActive(false);
            _gameObject[1].SetActive(true);
            _gameObject[2].SetActive(false);
        }
    }
}
