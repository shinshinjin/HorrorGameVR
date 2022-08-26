using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour, IInteraction
{
    public GameObject[] _gameObject;

    public string _activeText;

    private void Awake()
    {
        _activeText = "부순다";
    }

    public void Interaction()
    {
        if(ItemManager.Instance.CurrentItemName == "해머")
        {
            _activeText = "박스를 부쉈다";
            ItemManager.Instance.UsedItem();
            UIManager.Instance.EraseInfoText();
            _gameObject[0].SetActive(true);
            _gameObject[1].SetActive(false);
            Destroy(gameObject, 2f);
        }

        else
        {
            _activeText = "부술만한 도구가 없습니다.";
        }
    }
   
}