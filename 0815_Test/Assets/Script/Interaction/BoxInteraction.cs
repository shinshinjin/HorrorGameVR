using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour, IInteraction
{
    public GameObject[] _gameObject;

    public string _activeText;

    private void Awake()
    {
        _activeText = "�μ���";
    }

    public void Interaction()
    {
        if(ItemManager.Instance.CurrentItemName == "�ظ�")
        {
            _activeText = "�ڽ��� �ν���";
            ItemManager.Instance.UsedItem();
            UIManager.Instance.EraseInfoText();
            _gameObject[0].SetActive(true);
            _gameObject[1].SetActive(false);
            Destroy(gameObject, 2f);
        }

        else
        {
            _activeText = "�μ����� ������ �����ϴ�.";
        }
    }
   
}