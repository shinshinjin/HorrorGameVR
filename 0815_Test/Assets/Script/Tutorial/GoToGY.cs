using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToGY : MonoBehaviour
{
    public Transform Player;
    public Transform Target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LockDoor"))
        {
            Debug.Log("�п� ���");
            Player.position = Target.position;
            UIManager.Instance.EraseInfoText();
            
        }
    }
}
