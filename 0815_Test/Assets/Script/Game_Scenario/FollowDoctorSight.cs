using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowDoctorSight : MonoBehaviour
{
    public FollowDoctorMove _move;
    public bool IsFind;
    
    public UnityEvent FindPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && IsFind == false)
        {
            IsFind = true;
            _move.Speed = 10f;
            FindPlayer.Invoke();
        }
    }
}
