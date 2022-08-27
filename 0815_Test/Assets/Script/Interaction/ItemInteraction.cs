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
        _activeText = "������ ȹ���ϱ� (E)";
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
        if (ItemName == "11���ǽ� ����")
        {
            ItemManager.Instance.IsHave11ClassKey = true;
        }

        if (ItemName == "����Ʈ��")
        {
            ItemManager.Instance.IsHavePhone = true;
        }

        if (ItemName == "Ʃ�丮�� �湮 ����")
        {
            ItemManager.Instance.IsHaveTutorialKey = true;
        }

        if (ItemName == "����̹�")
        {
            ItemManager.Instance.IsHaveDriver = true;
        }

        if (ItemName == "�ظ�")
        {
            ItemManager.Instance.IsHaveHammer = true;
        }

        if (ItemName == "��Ʈ��")
        {
            ItemManager.Instance.IsHaveNoteBook = true;
        }

        if (ItemName == "â�� ����")
        {
            ItemManager.Instance.IsHaveRingKey = true;
        }

        if (ItemName == "101ȣ ����")
        {
            ItemManager.Instance.IsHave101Key = true;
        }

        if (ItemName == "������") 
        {
            ItemManager.Instance.IsHaveLighter = true;
        }

        if (ItemName == "�� ������Ʈ ������")
        {
            ItemManager.Instance.IsHaveScreenRemote = true;
        }

        if (ItemName == "CCTV") 
        {
            ItemManager.Instance.IsHaveCCTV = true;
        }

        if (ItemName == "12���ǽ� â��� ����")
        {
            ItemManager.Instance.IsHave12ClassStorageKey = true;
        }

        if (ItemName == "���� ����ġ") 
        {
            ItemManager.Instance.IsHaveLightSwitch = true;
        }

        if (ItemName == "�������� ��") 
        {
            ItemManager.Instance.IsHaveBrain = true;
        }

        if (ItemName == "��ũ�� �ݰ� ����") 
        {
            ItemManager.Instance.IsHaveScreenCofferKey = true;
        }

        if (ItemName == "�۾������ ����") 
        {
            ItemManager.Instance.IsHaveTherapyRoomKey = true;
        }

        if (ItemName == "���� �� ����") 
        {
            ItemManager.Instance.IsHaveHospitalKey = true;
        }

        if (ItemName == "�������� �̸�ǥ")
        {
            ItemManager.Instance.IsHaveNamePlate = true;
        }

        if (ItemName == "���� �� ����")
        {
            ItemManager.Instance.IsHaveMainKey = true;
        }
    }
    private void BreakItem()
    {
        gameObject.SetActive(false);
    }
}
    