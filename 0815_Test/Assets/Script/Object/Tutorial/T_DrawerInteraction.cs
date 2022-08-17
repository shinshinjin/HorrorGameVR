using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_DrawerInteraction : MonoBehaviour , IInteraction
{
    public Transform _player;

    private bool _isOpen;
    private bool _isMoveDrawer;
    private float _elapsedTime;
    private float _canInteractionDistance = 6f;

    private void Interaction()
    {
        if(_isOpen)
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
        if(Input.GetMouseButtonDown(0) && Vector3.Distance(transform.position, _player.position) < _canInteractionDistance && _isMoveDrawer == false)
        {
            Interaction();
        }
    }

    IEnumerator Open()
    {
        while (true)
        {
            _isMoveDrawer = true;
            transform.Translate(-0.05f, 0, 0);
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
                _isMoveDrawer = false;
                break;
            }
            Debug.Log("열리는 중");
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Close()
    {
        while (true)
        {
            _isMoveDrawer = true;
            transform.Translate(0.05f, 0, 0);
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
                _isMoveDrawer = false;
                break;
            }
            Debug.Log("닫히는 중");
            yield return new WaitForSeconds(0.01f);
        }
    }
}
