using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour , IInteraction
{
    public bool IsOpen = false;

    private void Interaction()
    {
        if(IsOpen == false)
            DoorOpen();

        else
            DoorClose();
    }

    void DoorOpen()
    {

    }

    void DoorClose()
    {

    }
}
