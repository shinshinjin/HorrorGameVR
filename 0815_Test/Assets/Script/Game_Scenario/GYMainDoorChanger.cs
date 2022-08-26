using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GYMainDoorChanger : MonoBehaviour
{
    private SphereCollider _collider;
    private DoorInteraction _doorInteraction;
    private bool _isEventActived;

    private void Awake()
    {
        _collider = GetComponentInChildren<SphereCollider>();
        _doorInteraction = GetComponentInChildren<DoorInteraction>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (ItemManager.Instance.IsHaveNoteBook && _isEventActived == false)
        {
            _isEventActived = true;
            if(_doorInteraction.IsOpen)
            {
                _doorInteraction.IsMoveDoor = true;
                StartCoroutine(_doorInteraction.Close());
            }
            gameObject.tag = "LockDoor";
            _collider.enabled = false;
        }
    }
}
