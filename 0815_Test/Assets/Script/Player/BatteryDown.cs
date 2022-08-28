using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDown : MonoBehaviour
{
    public GameObject _smartPhone;

    private bool _isBatteryDown;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && _isBatteryDown == false)
        {
            _isBatteryDown = true;
            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("배터리 방전으로 손전등이 꺼져버렸다...", 2f);
            _smartPhone.SetActive(false);
        }
    }
}
