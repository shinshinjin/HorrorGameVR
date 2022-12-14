using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GYMainDoorEvent : MonoBehaviour
{
    public GameObject Class10Door;
    public GameObject _JumpSquare;

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
            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("어.. 어라? 왜 문이 멋대로..", 2f);
            UIManager.Instance.GuideText.text = "집으로 갈 방법을 찾자";
            _JumpSquare.SetActive(true);
            Class10Door.tag = "Door";
            Camera.main.cullingMask = -1;
        }
    }
}
