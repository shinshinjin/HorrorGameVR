using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    private DrawerInteraction _drawer;
    private RaycastHit _hit;
    private float _distance = 6f;
    
    private void Update()
    {
        DrawerInteract();
    }

    private void DrawerInteract()
    {
        Debug.DrawRay(transform.position, transform.forward * _distance, Color.red);
        UIManager.Instance.InteractEraseText();
        
        if (Physics.Raycast(transform.position, transform.forward, out _hit, _distance))
        {

            if (_hit.transform.CompareTag("Drawer"))
            {
                _drawer = _hit.transform.GetComponent<DrawerInteraction>();
                UIManager.Instance.InteractDrawText(_drawer._activeText);
            }

            if (Input.GetMouseButtonDown(0) && _drawer._isMoveDrawer == false)
            {
                _drawer.Interaction();
            }
        }
    }
}
