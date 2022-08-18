using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    private DrawerInteraction _drawer;
    private DoorInteraction _door;
    private RaycastHit _hit;
    private float _distance = 6f;


    private void Update()
    {
        UIManager.Instance.InteractEraseText();
        if (Physics.Raycast(transform.position, transform.forward, out _hit, _distance))
        {
            if(_hit.transform.CompareTag("Drawer"))
            {
                DrawerInteract();
            }

            if(_hit.transform.CompareTag("Door"))
            {
                DoorInteract();
            }

        }

    }

    private void DrawerInteract()
    {
        //Debug.DrawRay(transform.position, transform.forward * _distance, Color.red);
        //UIManager.Instance.InteractEraseText();
        
        _drawer = _hit.transform.GetComponent<DrawerInteraction>();
        UIManager.Instance.InteractDrawText(_drawer._activeText);
        Debug.Assert(_drawer != null);

        if (Input.GetMouseButtonDown(0) && _drawer._isMoveDrawer == false)
        {
            _drawer.Interaction();
        }
        
    }

    private void DoorInteract()
    {
        
        _door = _hit.transform.GetComponent<DoorInteraction>();
        UIManager.Instance.InteractDrawText(_door._activeText);
        Debug.Assert(_door != null);

        if (Input.GetMouseButtonDown(0) && _door._isMoveDoor == false)
        {
            _door.Interaction();
        }
        
    }
}
