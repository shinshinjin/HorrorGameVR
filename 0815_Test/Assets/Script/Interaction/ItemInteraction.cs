using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour , IInteraction
{
    public string ItemName { get; set; }

    private AudioSource _getItemSound;

    public string _activeText;
    
    private void Awake()
    {
        _getItemSound = GetComponent<AudioSource>();
        _activeText = "아이템 획득하기 (E)";
    }

    public void Interaction()
    {
        _getItemSound.Play();

        CheckItem();

        Invoke("BreakItem", 0.2f);
    }

    private void CheckItem()
    {
        Debug.Assert(ItemName != null);
        if (ItemName == "11강의실 열쇠")
        {
            ItemManager.Instance.IsHave11ClassKey = true;
        }

        if (ItemName == "스마트폰")
        {
            ItemManager.Instance.IsHavePhone = true;
        }

        if (ItemName == "튜토리얼 방문 열쇠")
        {
            ItemManager.Instance.IsHaveTutorialKey = true;
        }

        if (ItemName == "드라이버")
        {
            ItemManager.Instance.IsHaveDriver = true;
        }

        if (ItemName == "해머")
        {
            ItemManager.Instance.IsHaveHammer = true;
        }

        if (ItemName == "노트북")
        {
            ItemManager.Instance.IsHaveNoteBook = true;
        }

        if (ItemName == "창고 열쇠")
        {
            ItemManager.Instance.IsHaveRingKey = true;
        }

        if (ItemName == "101호 열쇠")
        {
            ItemManager.Instance.IsHave101Key = true;
        }

        if (ItemName == "라이터") 
        {
            ItemManager.Instance.IsHaveLighter = true;
        }

        if (ItemName == "빔 프로젝트 리모컨")
        {
            ItemManager.Instance.IsHaveScreenRemote = true;
        }

        if (ItemName == "CCTV") 
        {
            ItemManager.Instance.IsHaveCCTV = true;
        }

        if (ItemName == "12강의실 창고방 열쇠")
        {
            ItemManager.Instance.IsHave12ClassStorageKey = true;
        }

        if (ItemName == "전등 스위치") 
        {
            ItemManager.Instance.IsHaveLightSwitch = true;
        }

        if (ItemName == "누군가의 뇌") 
        {
            ItemManager.Instance.IsHaveBrain = true;
        }

        if (ItemName == "스크린 금고 열쇠") 
        {
            ItemManager.Instance.IsHaveScreenCofferKey = true;
        }

        if (ItemName == "작업요법실 열쇠") 
        {
            ItemManager.Instance.IsHaveTherapyRoomKey = true;
        }

        if (ItemName == "병원 문 열쇠") 
        {
            ItemManager.Instance.IsHaveHospitalKey = true;
        }

        if (ItemName == "누군가의 이름표")
        {
            ItemManager.Instance.IsHaveNamePlate = true;
        }

        if (ItemName == "병원 문 열쇠")
        {
            ItemManager.Instance.IsHaveMainKey = true;
        }
    }
    private void BreakItem()
    {
        gameObject.SetActive(false);
    }
}
    