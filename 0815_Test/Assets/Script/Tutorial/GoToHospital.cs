using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToHospital : MonoBehaviour
{
    [SerializeField]
    GameObject _gameObject;

    public Transform Player;
    public Transform Target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("병원 출발");
            Player.position = Target.position;
            _gameObject.SetActive(false);
        }
    }
}
