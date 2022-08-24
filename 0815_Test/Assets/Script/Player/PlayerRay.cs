using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    private DrawerInteraction _drawer;
    private DoorInteraction _door;
    private LockDoorInteraction _lockDoor;
    private ItemInteraction _item;
    private RaycastHit _hit;
    private float _distance = 6f;

    
    private void Update()
    {
        UIManager.Instance.EraseInteractText();
        if (Physics.Raycast(transform.position, transform.forward, out _hit, _distance))
        {
            if(_hit.transform.CompareTag("Drawer"))
            {
                DrawerInteract();
            }

            if (_hit.transform.CompareTag("Door"))
            {
                DoorInteract();
            }

            if (_hit.transform.CompareTag("LockDoor"))
            {
                LockDoorInteract();
            }

            if (_hit.transform.CompareTag("Item"))
            {
                ItemInteract();
            }


        }
        
    }
    private void DrawerInteract()
    {
        _drawer = _hit.transform.GetComponent<DrawerInteraction>();
        UIManager.Instance.DrawInteractText(_drawer._activeText);
        Debug.Assert(_drawer != null);

        if (Input.GetKeyDown(KeyCode.E) && _drawer._isMoveDrawer == false && GameManager.Instance.IsPaused == false)
        {
            _drawer.Interaction();
        }
    }
    private void LockDoorInteract()
    {
        _lockDoor = _hit.transform.GetComponent<LockDoorInteraction>();
        UIManager.Instance.DrawInteractText(_lockDoor._activeText);
        Debug.Assert(_lockDoor != null);

        if (Input.GetKeyDown(KeyCode.E) && _lockDoor._isMoveDoor == false && GameManager.Instance.IsPaused == false)
        {
            _lockDoor.Interaction();
        }
    }
    private void DoorInteract()
    {
        _door = _hit.transform.GetComponent<DoorInteraction>();
        UIManager.Instance.DrawInteractText(_door.ActiveText);
        Debug.Assert(_door != null);

        if (Input.GetKeyDown(KeyCode.E) && _door.IsMoveDoor == false && GameManager.Instance.IsPaused == false)
        {
            _door.Interaction();
        }
    }

    private void ItemInteract()
    {
        _item = _hit.transform.GetComponent<ItemInteraction>();
        UIManager.Instance.DrawInteractText(_item._activeText);
        if(Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _item.ItemName = _hit.transform.name;
            _item.Interaction();
        }
    }
}
