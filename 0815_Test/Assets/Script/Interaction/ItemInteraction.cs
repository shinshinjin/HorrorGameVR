using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour , IInteraction
{
    public string ItemName { get; set; }

    public string _activeText;
    
    private void Awake()
    {
        _activeText = "������ ȹ���ϱ� (E)";
    }

    public void Interaction()
    {
        
        Debug.Assert(ItemName != null);
        if(ItemName == "11���ǽ� ����")
        {
            ItemManager.Instance.IsHave11ClassKey = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "����Ʈ��")
        {
            ItemManager.Instance.IsHavePhone = true;
            gameObject.SetActive(false);
        }

        if(ItemName == "Ʃ�丮�� �湮 ����")
        {
            ItemManager.Instance.IsHaveTutorialKey = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "����̹�")
        {
            ItemManager.Instance.IsHaveDriver = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "�ظ�")
        {
            ItemManager.Instance.IsHaveHammer = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "��Ʈ��")
        {
            ItemManager.Instance.IsHaveNoteBook = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "â�� ����")
        {
            ItemManager.Instance.IsHaveRingKey = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "101ȣ ����")
        {
            ItemManager.Instance.IsHave101Key = true;
            gameObject.SetActive(false);
        }

    }
}
