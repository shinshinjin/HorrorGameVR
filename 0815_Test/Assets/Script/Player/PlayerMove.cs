using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private UserInput _input;
    private Rigidbody _rigidbody;
    private CapsuleCollider _capsuleCollider;
    public GameObject _camera;
    public GameObject _light;
    private Vector3 _moveVector;

    private bool _isJump;
    private bool _isSitDown;


    [SerializeField]
    private float _speed;

    private void Awake()
    {
        _input = GetComponent<UserInput>();
        _rigidbody = GetComponent<Rigidbody>();
        _capsuleCollider = GetComponent<CapsuleCollider>();
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

        if(Input.GetKey(KeyCode.LeftControl) && _isSitDown == false)
        {
            _isSitDown = true;
        }
        if(!Input.GetKey(KeyCode.LeftControl))
        {
            _isSitDown = false;
        }


        Sit();
        Move();
    }

    private void Move()
    {
        _moveVector = Vector3.right * _input.InputX + Vector3.forward * _input.InputY;


        _moveVector = Camera.main.transform.TransformDirection(_moveVector);
        _moveVector.y = 0f;
        _moveVector.Normalize();

        transform.position += _moveVector * _speed * Time.fixedDeltaTime;
    }

    private void Sit()
    {
        if(_isSitDown)
        {
            transform.localPosition = new Vector3(transform.position.x, 2, transform.position.z);
            if(transform.localPosition.y <= 2f)
                _rigidbody.velocity = Vector3.zero;
            transform.localScale = new Vector3(transform.localScale.x, 2, transform.localScale.z);
            _speed = 2.5f;
            _capsuleCollider.height = 1;
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x, 4, transform.localScale.z);
            _capsuleCollider.height = 2;
        }
    }
}
