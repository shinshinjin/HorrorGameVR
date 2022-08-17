using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float InputX;
    public float InputY;

    public float MouseInputX;
    public float MouseInputY;
    [SerializeField]
    public bool IsLightOn = true;

    private void FixedUpdate()
    {
        InputX = Input.GetAxisRaw("Horizontal");
        InputY = Input.GetAxisRaw("Vertical");

        MouseInputX = Input.GetAxis("Mouse X");
        MouseInputY = Input.GetAxis("Mouse Y");

        if(Input.GetKeyDown(KeyCode.F) && IsLightOn == true)
        {
            IsLightOn = false;
        }
        else if(Input.GetKeyDown(KeyCode.F) && IsLightOn == false)
        {
            IsLightOn = true;    
        }
    }
}
