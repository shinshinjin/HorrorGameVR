using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GYMainDoorEvent : MonoBehaviour
{
    public GameObject Class10Door;

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

            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("��.. ���? �� ���� �ڴ��..", 2f);
            UIManager.Instance.GuideText.text = "������ �� ����� ã��";

            Class10Door.tag = "Door";
            Camera.main.cullingMask = -1;
        }
    }
}
