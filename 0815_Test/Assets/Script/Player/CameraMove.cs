using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private UserInput _input;
    private CapsuleCollider _cameraPosition;
    private PlayerMove _move;
    public Transform _player;

    private float _speed = 4f;
    private float xRotate = 0.0f;
    
    private void Awake()
    {
        _cameraPosition = GetComponentInParent<CapsuleCollider>();
        _move = GetComponentInParent<PlayerMove>();
        _input = GetComponentInParent<UserInput>();
    }

    private void Update()
    {
        if(GameManager.Instance.IsPaused == false)
        {
            Move();
        }
    }

    private void Move()
    {
        if(_move._isSitDown)
        {
            transform.position = _player.transform.position;
        }
        else
        {
            transform.position = _player.transform.position + new Vector3(0, 3f, 0);
        }

        float yRotateSize = _input.MouseInputX * _speed;

        float yRotate = transform.eulerAngles.y + yRotateSize;

        float xRotateSize = -_input.MouseInputY * _speed;

        xRotate = Mathf.Clamp(xRotate + xRotateSize, -90, 90);

        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);   
    }
}
