using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowDoctorFindRange : MonoBehaviour
{
    public UnityEvent PlayerDead;
    public FollowDoctorSight Sight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Sight.IsFind)
        {
            PlayerDead.Invoke();
        }
    }
}
