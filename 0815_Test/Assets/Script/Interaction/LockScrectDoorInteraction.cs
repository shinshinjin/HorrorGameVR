using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScrectDoorInteraction : MonoBehaviour
{
    public bool IsMoveDoor;
    public bool IsOpen;
    public string ActiveText;

    private float _elapsedTime;
    private float _doorOpenCooltime = 1.4f;
    private float _initTime = 0f;

    private float _moveSpeed = 1.25f;



    private void Awake()
    {
        ActiveText = "열기 (E)";
    }

    public void Interaction()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        IsMoveDoor = true;
        if (IsOpen)
        {
            ActiveText = "열기 (E)";
            StartCoroutine(Close());
            IsOpen = false;
        }
        else
        {
            ActiveText = "닫기 (E)";
            StartCoroutine(Open());
            IsOpen = true;
        }
        yield return null;
    }
    IEnumerator Open()
    {
        while (true)
        {
            transform.Rotate(0, 0, -_moveSpeed);

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
    public IEnumerator Close()
    {
        while (true)
        {
            transform.Rotate(0, 0, _moveSpeed);

            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > _doorOpenCooltime)
            {
                _elapsedTime = _initTime;
                IsMoveDoor = false;
                break;
            }
            Debug.Log("닫히는 중");
            yield return null;
        }
    }
}
