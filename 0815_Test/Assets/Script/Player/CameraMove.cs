using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private UserInput _input;
    private float _speed = 4f;
    private float xRotate = 0.0f;
    private void Awake()
    {
        _input = GetComponent<UserInput>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        // 좌우로 움직인 마우스의 이동량 * 속도에 따라 카메라가 좌우로 회전할 양 계산
        float yRotateSize = Input.GetAxis("Mouse X") * _speed;
        // 현재 y축 회전값에 더한 새로운 회전각도 계산
        float yRotate = transform.eulerAngles.y + yRotateSize;

        // 위아래로 움직인 마우스의 이동량 * 속도에 따라 카메라가 회전할 양 계산(하늘, 바닥을 바라보는 동작)
        float xRotateSize = -Input.GetAxis("Mouse Y") * _speed;

        xRotate = Mathf.Clamp(xRotate + xRotateSize, -90, 90);

        // 카메라 회전량을 카메라에 반영(X, Y축만 회전)
        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);   
    }
}
