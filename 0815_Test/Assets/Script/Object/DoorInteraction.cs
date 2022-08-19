using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour , IInteraction
{
    public bool _isMoveDoor;
    public string _activeText;

    private bool _isOpen;
    private float _elapsedTime;
    private float _doorOpenCooltime = 0.7f;
    private float _initTime = 0f;

    private float _moveSpeed = 2.5f;

    private void Awake()
    {
        _activeText = "문 열기";
    }

    public void Interaction()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        _isMoveDoor = true;
        if (_isOpen)
        {
            _activeText = "문 열기";
            StartCoroutine(Open());
            _isOpen = false;
        }
        else
        {
            _activeText = "문 닫기";
            StartCoroutine(Close());
            _isOpen = true;
        }
        yield return null;
    }
    IEnumerator Open()
    {
        while (true)
        {
            transform.Rotate(0, -_moveSpeed, 0);

            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > _doorOpenCooltime)
            {
                _elapsedTime = _initTime;
                _isMoveDoor = false;
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
            transform.Rotate(0, _moveSpeed, 0);

            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > _doorOpenCooltime)
            {
                _elapsedTime = _initTime;
                _isMoveDoor = false;
                break;
            }
            Debug.Log("닫히는 중");
            yield return null;
        }
    }

    // 기존 델타타임 
}
