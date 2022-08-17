using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHideAndHold : MonoBehaviour
{
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
