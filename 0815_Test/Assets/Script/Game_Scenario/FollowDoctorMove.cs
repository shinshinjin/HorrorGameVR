using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowDoctorMove : MonoBehaviour
{
    
    public float Speed;

    private void Awake()
    {
        Speed = 1f;
    }
    private void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

}
