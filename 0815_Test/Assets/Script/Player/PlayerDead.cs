using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{   
    public Camera MainCamera;
    public Camera DeadCamera;

    public Transform Player;
    public Transform SpawnPosition;

    public FollowDoctorEvent DoctorEvent;
    public FollowDoctorMove SetDoctorSpeed;

    public AudioClip DeadSound;

    private bool _isDead;
    private float _spwanCooltime = 1.5f;
    private float _eleaspedTime = 0f;

    private void FixedUpdate()
    {
        if(_isDead)
        {
            GameManager.Instance.IsPaused = true;
            DeadCamera.enabled = true;
            MainCamera.enabled = false;

            _eleaspedTime += Time.deltaTime;
            if (_eleaspedTime > _spwanCooltime)
            {
                _isDead = false;
                DeadCamera.enabled = false;
                MainCamera.enabled = true;
                GameManager.Instance.IsPaused = false;
                Player.position = SpawnPosition.position;
                DoctorEvent.InitDoctor();
                DoctorEvent.SpawnDoctor();
                DoctorEvent.PointChanger(0);
                SetDoctorSpeed.Speed = 1f;
                _eleaspedTime = 0f;
            }
        }
    }
    public void Dead()
    {
        Debug.Log("Dead½ÇÇàµÊ");
        AudioSource.PlayClipAtPoint(DeadSound, transform.position);
        _isDead = true;
    }

}
