using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDown : MonoBehaviour
{
    public GameObject _smartPhone;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("배터리 방전으로 손전등이 꺼져버렸다...", 2f);
            _smartPhone.SetActive(false);
        }
    }
}
