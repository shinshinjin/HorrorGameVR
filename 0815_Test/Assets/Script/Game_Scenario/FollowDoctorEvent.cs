using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDoctorEvent : MonoBehaviour
{
    public Transform Player;
    public Transform[] Points;

    public GameObject Sight;
    public GameObject Doctor;

    public Transform DoctorSpawnPosition;

    private Transform Target;

    private int _pointIndex;

    private void Awake()
    {
        Target = Points[0].transform;
    }
    private void Update()
    {
        //Doctor.transform.LookAt(Target);
        Doctor.transform.forward = Target.position - Doctor.transform.position;
    }
    public void SpawnDoctor()
    {
        Sight.SetActive(true);
        Points[3].gameObject.SetActive(true);
        Target = Points[3].transform;
        Sight.GetComponent<FollowDoctorSight>().IsFind = false;
        Doctor.SetActive(true);
    }

    public void InitDoctor()
    {
        Doctor.transform.position = DoctorSpawnPosition.position;
        Sight.SetActive(false);
        Doctor.SetActive(false);
    }

    public void PointChanger(int currentPointIndex)
    {
        Points[currentPointIndex].gameObject.SetActive(false);
        if (currentPointIndex >= 3)
        {
            currentPointIndex = 0;
        }
        else
        {
            currentPointIndex++;
        }
        Points[currentPointIndex].gameObject.SetActive(true);
        _pointIndex = currentPointIndex;
        Target = Points[_pointIndex].transform;
    }

    public void FollowPlayer()
    {
        Points[_pointIndex].gameObject.SetActive(false);
        Target = Player.transform;
    }
}