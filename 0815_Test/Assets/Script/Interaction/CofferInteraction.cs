using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofferInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;

    public AudioClip Open;
    public AudioClip Locked;
    private AudioSource _cofferSound;

    private void Awake()
    {
        _activeText = "���谡 �ʿ��ϴ�";
    }
    private void Update()
    {
        if(ItemManager.Instance.CurrentItemName == "��ũ�� �ݰ� ����")
        {
            _activeText = "����� ����";
        }
        else
        {
            _activeText = "���谡 �ʿ��ϴ�";
        }
    }
    public void Interaction()
    {
        if (ItemManager.Instance.CurrentItemName == "��ũ�� �ݰ� ����")
        {
            ItemManager.Instance.UsedItem();
            gameObject.SetActive(false);
        }
    }
}
