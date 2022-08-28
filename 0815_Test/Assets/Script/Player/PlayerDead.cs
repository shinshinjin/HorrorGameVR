using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{   
    public Camera MainCamera;
    public Camera DeadCamera;
    private bool _isDead;

    private void FixedUpdate()
    {
        if(_isDead)
        {
            GameManager.Instance.IsPaused = true;
            DeadCamera.enabled = true;
            MainCamera.enabled = false;
            
        }
    }
    public void Dead()
    {
        Debug.Log("Dead½ÇÇàµÊ");
        _isDead = true;
    }

}
