using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorStepSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource _walk;

    private void Awake()
    {
        _walk = GetComponent<AudioSource>();    
    }
    public void AudioPlay()
    {
        _walk.Play();
    }
}
