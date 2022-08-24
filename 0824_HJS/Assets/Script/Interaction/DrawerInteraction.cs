using System.Collections;
using System.Collections.Generic;
using UnityEngine;  


public class DrawerInteraction : MonoBehaviour , IInteraction
{
    
    public bool _isMoveDrawer;
    public string _activeText;

    public AudioClip OpenDrawer;
    public AudioClip CloseDrawer;

    private AudioSource _drawerAudio;

    private bool _isOpen;
    private float _elapsedTime;
    [SerializeField]
    private float _drawerOpenCooltime = 0.4f;
    private float _initTime = 0f;

    [SerializeField]
    private float _moveSpeedZ = 0.05f;
    [SerializeField]
    private float _moveSpeedX = 0.05f;

    private void Awake()
    {
        _drawerAudio = GetComponent<AudioSource>();
        _activeText = "서랍 열기 (E)";
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
            _drawerAudio.clip = CloseDrawer;
            _activeText = "서랍 열기 (E)";
            _drawerAudio.Play();
            StartCoroutine(Close());
            _isOpen = false;
        }
        else
        {
            _drawerAudio.clip = OpenDrawer;
            _activeText = "서랍 닫기 (E)";
            _drawerAudio.Play();
            StartCoroutine(Open());
            _isOpen = true;
        }
        yield return null;
    }
    IEnumerator Open()
    {
        while (true)
        {
            
            transform.Translate(-_moveSpeedX, 0, -_moveSpeedZ);
            
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
            
            transform.Translate(_moveSpeedX, 0, _moveSpeedZ);
            
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
