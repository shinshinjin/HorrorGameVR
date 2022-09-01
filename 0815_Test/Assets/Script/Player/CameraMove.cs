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
        _input = GetComponent<UserInput>();
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

        if(OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        {
            Vector2 Joystick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

            if(Joystick.x < 0)
            {
                Debug.Log("완쪽");
                transform.Rotate(-90f,0,0);
            }
            else if(Joystick.x > 0)
            {
                Debug.Log("오른쪽");
                transform.Rotate(90f, 0, 0);
            }
        }

        //float yRotateSize = Input.GetAxis("Mouse X") * _speed;

        //float yRotate = transform.eulerAngles.y + yRotateSize;

        //float xRotateSize = -Input.GetAxis("Mouse Y") * _speed;

        //xRotate = Mathf.Clamp(xRotate + xRotateSize, -90, 90);

        //transform.eulerAngles = new Vector3(xRotate, yRotate, 0);   
    }
}
