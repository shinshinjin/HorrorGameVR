using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    private DrawerInteraction _drawer;
    private DoorInteraction _door;
    private LockDoorInteraction _lockDoor;
    private ItemInteraction _item;
    private BeamProjectInteraction _beamProject;
    private ScreenPuzzleKeyBoardInteraction _keyBoard;
    private MonitorInteraction _monitor;
    private BoxInteraction _box;
    private CofferInteraction _coffer;
    private NumberCofferInteraction _numberCoffer;
    private CCTVInteraction _CCTV;
    private SwitchInteraction _switch;
    private ButtonInteraction _tempSwitch;
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

            if(_hit.transform.CompareTag("BeamProject"))
            {
                BeamProjectInteract();
            }

            if (_hit.transform.CompareTag("KeyBoard"))
            {
                KeyBoardInteract();
            }

            if (_hit.transform.CompareTag("Box"))
            {
                BoxInteract();
            }

            if (_hit.transform.CompareTag("Monitor"))
            {
                MonitorInteract();
            }

            if(_hit.transform.CompareTag("Coffer"))
            {
                CofferInteract();
            }

            if(_hit.transform.CompareTag("CCTV"))
            {
                CCTVInteract();
            }

            if (_hit.transform.CompareTag("NumberCoffer"))
            {
                NumberCofferInteract();
            }

            if (_hit.transform.CompareTag("Switch"))
            {
                SwitchInteract();
            }

            if (_hit.transform.CompareTag("TempSwitch"))
            {
                TempSwitchInteract();
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

    private void BeamProjectInteract()
    {
        _beamProject = _hit.transform.GetComponent<BeamProjectInteraction>();
        UIManager.Instance.DrawInteractText(_beamProject._activeText);
        if(Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _beamProject.Interaction();
        }
    }

    private void KeyBoardInteract()
    {
        _keyBoard = _hit.transform.GetComponent<ScreenPuzzleKeyBoardInteraction>();
        UIManager.Instance.DrawInteractText(_keyBoard._activeText);
        if(Input.GetKeyDown(KeyCode.Q) && GameManager.Instance.IsPaused == false)
        {
            _keyBoard._screenIndex--;
            _keyBoard.Interaction();
        }
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _keyBoard._screenIndex++;
            _keyBoard.Interaction();
        }
    }
    private void BoxInteract()
    {
        _box = _hit.transform.GetComponent<BoxInteraction>();
        UIManager.Instance.DrawInteractText(_box._activeText);
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _box.Interaction();
        }
    }
    private void MonitorInteract()
    {
        _monitor = _hit.transform.GetComponent<MonitorInteraction>();
        UIManager.Instance.DrawInteractText(_monitor._activeText);
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false) 
        {
            _monitor.Interaction();
        }
    }

    private void CofferInteract()
    {
        _coffer = _hit.transform.GetComponent<CofferInteraction>();
        UIManager.Instance.DrawInteractText(_coffer._activeText);
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _coffer.Interaction();
        }
    }

    private void CCTVInteract()
    {
        _CCTV = _hit.transform.GetComponent<CCTVInteraction>();
        UIManager.Instance.DrawInteractText(_CCTV._activeText);
        if(Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _CCTV.Interaction();
        }
    }

    private void NumberCofferInteract()
    {
        _numberCoffer = _hit.transform.GetComponent<NumberCofferInteraction>();
        UIManager.Instance.DrawInteractText(_numberCoffer._activeText);
        if (Input.GetKeyDown(KeyCode.E))
        {
            _numberCoffer.Interaction();
        }
    }

    private void SwitchInteract()
    {
        _switch = _hit.transform.GetComponent<SwitchInteraction>();
        UIManager.Instance.DrawInteractText(_switch._activeText);
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _switch.Interaction();
        }
    }

    private void TempSwitchInteract()
    {
        _tempSwitch = _hit.transform.GetComponent<ButtonInteraction>();
        UIManager.Instance.DrawInteractText(_tempSwitch._activeText);
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.IsPaused == false)
        {
            _tempSwitch.Interaction();
        }
    }
}
