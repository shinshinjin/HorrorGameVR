using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CCTVInteraction : MonoBehaviour, IInteraction
{
    public UnityEvent OnCCTV;
    public string _activeText;
    public GameObject[] CCTV;

    private bool _isCCTVOn;


    private void Update()
    {
        if(ItemManager.Instance.CurrentItemName == "CCTV")
        {
            _activeText = "CCTV 장착하기 (E)";
        }
        else
        {
            _activeText = "CCTV가 필요하다";
        }
    }

    public void Interaction()
    {
        if(ItemManager.Instance.CurrentItemName == "CCTV" && _isCCTVOn == false)
        {
            _isCCTVOn = true;
            CCTV[0].SetActive(true);
            CCTV[1].SetActive(true);
            _activeText = "CCTV가 이미 장착되어 있습니다";
            OnCCTV.Invoke();
            ItemManager.Instance.UsedItem();
        }
    }


}
