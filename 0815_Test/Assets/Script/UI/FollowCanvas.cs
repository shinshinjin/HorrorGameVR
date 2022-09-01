using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCanvas : MonoBehaviour
{
    public Transform Player;

    private Vector3 _canvasPosition;

    private void Update()
    {
        _canvasPosition = Player.position;
        _canvasPosition.z = Player.position.z + 15f;
        transform.position = _canvasPosition;
    }
}
