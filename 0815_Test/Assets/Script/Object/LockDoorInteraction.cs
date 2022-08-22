using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoorInteraction : MonoBehaviour, IInteraction
{
    public bool _isMoveDoor;
    public string _activeText;

    public string UnlockItemName;

    private bool _isOpen;
    private float _elapsedTime;
    private float _doorOpenCooltime = 1.4f;
    private float _initTime = 0f;

    private float _moveSpeed = 1.25f;

    private void Awake()
    {
        _activeText = "�� ���� (E)";
    }

    public void Interaction()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        if(ItemManager.Instance.CurrentItemName == UnlockItemName)
        {

            _isMoveDoor = true;
            if (_isOpen)
            {
                _activeText = "�� ���� (E)";
                StartCoroutine(Open());
                _isOpen = false;
            }
            else
            {
                _activeText = "�� �ݱ� (E)";
                StartCoroutine(Close());
                _isOpen = true;
            }
        }
        else
        {
            _activeText = "���� ����ִ�.";
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
            Debug.Log("������ ��");
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
            Debug.Log("������ ��");
            yield return null;
        }
    }
}
