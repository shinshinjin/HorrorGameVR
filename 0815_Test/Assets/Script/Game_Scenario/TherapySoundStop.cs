using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TherapySoundStop : MonoBehaviour
{
    public TherapyLightEventManager Therapy;
    private void OnTriggerEnter(Collider other)
    {
        if(Therapy.IsSoundOn)
        {
            Therapy.StopShowerSound();
            gameObject.SetActive(false);
        }
    }
}
