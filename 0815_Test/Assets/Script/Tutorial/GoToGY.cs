using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToGY : MonoBehaviour
{
    public Transform Player;
    public Transform Target;
    public GameObject Tutorial_Map;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LockDoor"))
        {
            Debug.Log("학원 출발");
            Player.position = Target.position;
            UIManager.Instance.EraseInfoText();
            Tutorial_Map.SetActive(false);
        }
    }
}
