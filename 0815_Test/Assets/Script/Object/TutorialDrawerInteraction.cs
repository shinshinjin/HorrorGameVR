using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDrawerInteraction : MonoBehaviour, IInteraction
{
    public bool _isMoveDrawer;
    public string _activeText;

    private bool _isOpen;
    private float _elapsedTime;
    private float _drawerOpenCooltime = 1f;
    private float _initTime = 0f;

    private float _moveSpeed = 0.05f;

    private void Awake()
    {
        _activeText = "���� ���� (E)";
    }

    public void Interaction()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        _isMoveDrawer = true;
        if (_isOpen)
        {
            _activeText = "���� ���� (E)";
            StartCoroutine(Close());
            _isOpen = false;
        }
        else
        {
            _activeText = "���� �ݱ� (E)";
            StartCoroutine(Open());
            _isOpen = true;
        }
        yield return null;
    }
    IEnumerator Open()
    {
        while (true)
        {

            transform.Translate(-_moveSpeed, 0, 0);

            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > _drawerOpenCooltime)
            {
                _elapsedTime = _initTime;
                _isMoveDrawer = false;
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

            transform.Translate(_moveSpeed, 0, 0);

            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > _drawerOpenCooltime)
            {
                _elapsedTime = _initTime;
                _isMoveDrawer = false;
                break;
            }
            Debug.Log("������ ��");
            yield return null;
        }
    }
}
