using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToHospital : MonoBehaviour
{
    public Transform Player;
    public Transform Target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("���� ���");
            Player.position = Target.position;
        }
    }
}
