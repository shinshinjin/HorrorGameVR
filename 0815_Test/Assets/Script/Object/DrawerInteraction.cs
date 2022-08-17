using System.Collections;
using System.Collections.Generic;
using UnityEngine;  


public class DrawerInteraction : MonoBehaviour , IInteraction
{
    public Transform _player;

    private bool _isOpen;
    private bool _isMoveDrawer;
    private float _elapsedTime;
    private float _canInteractionDistance = 6f;

    private void Interaction()
    {
        if( _isOpen )
        {
            StartCoroutine(Close());
            _isOpen = false;
        }
        else
        {
            StartCoroutine(Open());
            _isOpen = true;
        }
    }
    
    private void OnMouseOver()
    {
        if(Vector3.Distance(transform.position, _player.position) < _canInteractionDistance)
        {
            UIManager.Instance.InteractDrawText("��ȣ�ۿ��ϱ�", true);
        }
        else
        {
            UIManager.Instance.InteractDrawText("��ȣ�ۿ��ϱ�", false);
        }


        if (Input.GetMouseButtonDown(0) && GetDistanceFromInteractObject() < _canInteractionDistance && _isMoveDrawer == false)
        {
            Interaction();
        }
    }

    private void OnMouseExit()
    {
        UIManager.Instance.InteractDrawText("��ȣ�ۿ��ϱ�", false);
    }

    IEnumerator Open()
    {
        while(true)
        {
            _isMoveDrawer = true;
            transform.Translate(0, 0, -0.05f);
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
                _isMoveDrawer = false;
                break;
            }
            Debug.Log("������ ��");
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator Close()
    {
        while (true)
        {
            _isMoveDrawer = true;
            transform.Translate(0, 0, 0.05f);
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
                _isMoveDrawer = false;
                break;
            }
            Debug.Log("������ ��");
            yield return new WaitForSeconds(0.01f);
        }
    }

    private float GetDistanceFromInteractObject()
    {
        return Vector3.Distance(transform.position, _player.position);
    }
}
