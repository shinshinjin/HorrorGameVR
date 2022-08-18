using System.Collections;
using System.Collections.Generic;
using UnityEngine;  


public class DrawerInteraction : MonoBehaviour , IInteraction
{
    
    public bool _isMoveDrawer;
    public string _activeText;

    private bool _isOpen;
    private float _elapsedTime;

    private float _moveSpeed = 0.05f;

    private void Awake()
    {
        _activeText = "���� ����";
    }

    public void Interaction()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        _isMoveDrawer = true;
        if(_isOpen)
        {
            _activeText = "���� ����";
            StartCoroutine(Open());
            _isOpen = false;
        }
        else
        {
            _activeText = "���� �ݱ�";
            StartCoroutine(Close());
            _isOpen = true;
        }
        yield return null;
    }
    IEnumerator Open()
    {
        while (true)
        {
            
            transform.Translate(0, 0, _moveSpeed);
            
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
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
            
            transform.Translate(0, 0, -_moveSpeed);
            
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
                _isMoveDrawer = false;
                break;
            }
            Debug.Log("������ ��");
            yield return null;
        }
    }

}
