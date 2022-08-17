using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class DrawerInteraction : MonoBehaviour , IInteraction
{
    public Transform _player;

    private bool _isOpen;
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
        if (Input.GetMouseButtonDown(0) && Vector3.Distance(transform.position, _player.position) < _canInteractionDistance)
        {
            Interaction();
        }
    }

    IEnumerator Open()
    {
        while(true)
        {
            transform.Translate(0, 0, -0.05f);
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
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
            transform.Translate(0, 0, 0.05f);
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime > 0.5f)
            {
                _elapsedTime = 0f;
                break;
            }
            Debug.Log("������ ��");
            yield return new WaitForSeconds(0.01f);
        }
    }

}
