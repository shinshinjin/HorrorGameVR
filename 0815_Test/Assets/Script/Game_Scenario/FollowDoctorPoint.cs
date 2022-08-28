using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowDoctorPoint : MonoBehaviour
{
    public UnityEvent OnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("FollowDoctor"))
        {
            OnPoint.Invoke();
            Debug.Log("Ãæµ¹°¨ÁöµÊ");
        }
    }
}
