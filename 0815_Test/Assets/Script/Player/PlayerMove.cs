using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private UserInput _input;
    private Rigidbody _rigidbody;
    private Camera _camera;
    private Vector3 _moveVector;
    private CapsuleCollider _capsuleCollider;

    private AudioSource _audioSource;

    private bool _isChangeAudioClip;

    private bool _isRunning;
    private bool _isMoving; 

    public AudioClip Walking;
    public AudioClip Running;
    public AudioClip Sitting;

    public bool _isSitDown;

    public float _speed;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _camera = GetComponentInChildren<Camera>();
        _input = GetComponent<UserInput>();
        _rigidbody = GetComponent<Rigidbody>();
        _capsuleCollider = GetComponent<CapsuleCollider>();
    }
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftShift) && !_isSitDown)
        {
            _isRunning = true;
        }
        else
        {
            _isRunning = false;
        }

        if(Input.GetKey(KeyCode.LeftControl) && _isSitDown == false)
        {
            _isSitDown = true;
        }
        if(!Input.GetKey(KeyCode.LeftControl) && GameManager.Instance.IsInFan == false)
        {
            _isSitDown = false;
        }

        PlayMoveSound();
        if (GameManager.Instance.IsPaused == false)
        {
            Sit();
            Run();
            Move();
        }

    }

    private void Update()
    {
        

    }

    private void Move()
    {
        if (!_isRunning && !_isSitDown && _audioSource.clip != Walking)
        {
            _audioSource.clip = Walking;
            _isChangeAudioClip = true;
        }

        _moveVector = Vector3.right * _input.InputX + Vector3.forward * _input.InputY;
        _moveVector = Camera.main.transform.TransformDirection(_moveVector);
        _moveVector.y = 0f;
        _moveVector.Normalize();

        _rigidbody.MovePosition(transform.position + _moveVector * _speed * Time.fixedDeltaTime);
        //transform.position += _moveVector * _speed * Time.fixedDeltaTime;
    }
    private void Run()
    {
        if(_isRunning && _audioSource.clip != Running)
        {
            _audioSource.clip = Running;
            _isChangeAudioClip = true;
        }

        if(_isRunning)
        {
            _speed = 10f;
        }
        else
        {
            _speed = 5f;
        }
    }

    private void Sit()
    {
        if (_isSitDown && _audioSource.clip != Sitting)
        {
            _audioSource.clip = Sitting;
            _isChangeAudioClip = true;
        }

        if (_isSitDown)
        {
            _speed = 2.5f;
            _capsuleCollider.height = 0.1f;
        }
        else
        {
            _capsuleCollider.height = 2;
        }
    }

    private void PlayMoveSound()
    {
        if ((_input.InputX != 0f || _input.InputY != 0f) && _isMoving == false)
        {
            _audioSource.Play();
            _isMoving = true;
        }

        if ((_input.InputX == 0f && _input.InputY == 0f && _isMoving == true) || _isChangeAudioClip || GameManager.Instance.IsPaused)
        {
            _audioSource.Stop();
            _isMoving = false;
            _isChangeAudioClip = false;
        }
    }
}
