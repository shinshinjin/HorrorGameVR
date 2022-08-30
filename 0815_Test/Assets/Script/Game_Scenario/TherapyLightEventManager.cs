using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TherapyLightEventManager : MonoBehaviour
{
    public int Count = 0;
    public bool IsSoundOn;

    private AudioSource Water;
    private void Awake()
    {
        Water = GetComponent<AudioSource>();
    }
    public void PlayerShowerSound()
    {
        Water.Play();
        IsSoundOn = true;
    }

    public void StopShowerSound()
    {
        if (Water.isPlaying)
        {
            Water.Stop();
        }
    }
}
