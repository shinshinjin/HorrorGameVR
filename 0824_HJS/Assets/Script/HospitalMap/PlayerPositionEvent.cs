using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionEvent : MonoBehaviour
{
    public GameObject DoctorObject;

    private void OnTriggerEnter()
    {
        Debug.Log("Doctor ���");
        DoctorObject.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
    
}
