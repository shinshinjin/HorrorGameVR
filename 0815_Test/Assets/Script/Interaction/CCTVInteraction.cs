using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;
    public GameObject[] CCTV;

    private bool _isCCTVOn;


    private void Update()
    {
        if(ItemManager.Instance.CurrentItemName == "CCTV")
        {
            _activeText = "CCTV �����ϱ� (E)";
        }
        else
        {
            _activeText = "CCTV�� �ʿ��ϴ�";
        }
    }

    public void Interaction()
    {
        if(ItemManager.Instance.CurrentItemName == "CCTV" && _isCCTVOn == false)
        {
            _isCCTVOn = true;
            CCTV[0].SetActive(true);
            CCTV[1].SetActive(true);
            _activeText = "CCTV�� �̹� �����Ǿ� �ֽ��ϴ�";
        }
    }


}
