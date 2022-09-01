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
            StartCoroutine(UIManager.Instance.FadeInBackGround(0.1f));
            Debug.Log("�п� ���");
            Player.position = Target.position;
            UIManager.Instance.EraseInfoText();
            //Tutorial_Map.SetActive(false);
        }
    }
}
