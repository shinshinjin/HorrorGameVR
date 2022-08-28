using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowDoctorMove : MonoBehaviour
{
    public UnityEvent PlayerDead;
    public FollowDoctorSight Sight;
    public float Speed;

    private void Awake()
    {
        Speed = 1f;
    }
    private void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Sight.IsFind)
        {
            PlayerDead.Invoke();
        }
    }
}
