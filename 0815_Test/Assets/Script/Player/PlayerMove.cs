using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private UserInput _input;
    private Rigidbody _rigidbody;
    private Vector3 _moveVector;

    [SerializeField]
    private float _speed;

    private void Awake()
    {
        _input = GetComponent<UserInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            _speed = 8f;
        }
        else
        {
            _speed = 4f;
        }

        if(Input.GetKey(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(2, 2, 2);
            
        }
        else
        {
            transform.localScale = new Vector3(2, 4, 2);
        }
        
        
        Move();
    }

    private void Move()
    {
        _moveVector = Vector3.right * _input.InputX + Vector3.forward * _input.InputY;


        _moveVector = Camera.main.transform.TransformDirection(_moveVector);
        _moveVector.y = 0f;
        _moveVector.Normalize();

        //_rigidbody.MovePosition(_moveVector);
        transform.position += _moveVector * _speed * Time.fixedDeltaTime;
    }
}
