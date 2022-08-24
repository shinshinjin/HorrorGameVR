using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRoad : MonoBehaviour
{
    public PlayerMove Move;
    
    private void OnCollisionStay(Collision collision)
    {
        GameManager.Instance.IsInFan = true;
        Move._isSitDown = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        GameManager.Instance.IsInFan = false;
    }
}
