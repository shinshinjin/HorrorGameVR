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
        _activeText = "서랍 열기 (E)";
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
            _activeText = "서랍 열기 (E)";
            StartCoroutine(Close());
            _isOpen = false;
        }
        else
        {
            _activeText = "서랍 닫기 (E)";
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
            Debug.Log("열리는 중");
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
            Debug.Log("닫히는 중");
            yield return null;
        }
    }
}
