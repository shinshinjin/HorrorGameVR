using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour , IInteraction
{
    public bool IsMoveDoor;
    public string ActiveText;

    public AudioClip DoorOpen;
    public AudioClip DoorClose;

    private AudioSource _doorAudio;

    private bool _isOpen;
    private float _elapsedTime;
    private float _doorOpenCooltime = 1.4f;
    private float _initTime = 0f;

    private float _moveSpeed = 1.25f;



    private void Awake()
    {
        _doorAudio = GetComponent<AudioSource>();
        ActiveText = "문 열기 (E)";
    }

    public void Interaction()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        IsMoveDoor = true;
        if (_isOpen)
        {
            _doorAudio.clip = DoorClose;
            ActiveText = "문 열기 (E)";
            StartCoroutine(Close());
            _isOpen = false;
        }
        else
        {
            _doorAudio.clip = DoorOpen;
            ActiveText = "문 닫기 (E)";
            _doorAudio.Play();
            StartCoroutine(Open());
            _isOpen = true;
        }
        yield return null;
    }
    IEnumerator Open()
    {
        while (true)
        {
            transform.Rotate(0, _moveSpeed, 0);

            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > _doorOpenCooltime)
            {
                _elapsedTime = _initTime;
                IsMoveDoor = false;
                break;
            }
            Debug.Log("열리는 중");
            yield return null;
        }
    }
    IEnumerator Close()
    {
        while (true)
        {
            transform.Rotate(0, -_moveSpeed, 0);

            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > _doorOpenCooltime)
            {
                _elapsedTime = _initTime;
                IsMoveDoor = false;
                _doorAudio.Play();
                break;
            }
            Debug.Log("닫히는 중");
            yield return null;
        }
    }

    // 기존 델타타임 
}
