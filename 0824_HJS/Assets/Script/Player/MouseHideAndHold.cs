using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHideAndHold : MonoBehaviour
{
    private void Update()
    {
        if(GameManager.Instance.IsMouseLocked)
        {
            MouseLock();
        }
        else
        {
            MouseUnLock();
        }
    }

    private void MouseLock()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void MouseUnLock()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
