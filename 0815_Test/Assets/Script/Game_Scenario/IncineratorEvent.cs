using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IncineratorEvent : MonoBehaviour, IInteraction
{
    public UnityEvent BurningBrain;
    public AudioClip BrainIn;
    public AudioClip Fire;
    public GameObject StorageKey;
    public GameObject _HerCrying;

    public string ActiveText;

    private AudioSource _audio;

    private bool _isBrainIn;


    private void Update()
    {

        if(ItemManager.Instance.CurrentItemName == "�׳��� ��")
        {
            ActiveText = "���� �ִ´�";
        }
        else if(ItemManager.Instance.CurrentItemName == "������" && _isBrainIn)
        {
            ActiveText = "���� ���δ�";
        }
        else if(ItemManager.Instance.CurrentItemName == "������" && _isBrainIn == false)
        {
            ActiveText = "�¿���� ���� ����";
        }
        else
        {
            ActiveText = "���� �¿� �� ���� �� ����...";
        }




    }

    public void Interaction()
    {
        if (ItemManager.Instance.CurrentItemName == "�׳��� ��")
        {
            _isBrainIn = true;
        }

        if (ItemManager.Instance.CurrentItemName == "������" && _isBrainIn)
        {
            StorageKey.SetActive(true);
            BurningBrain.Invoke();
            UIManager.Instance.GuideText.text = "���� Ż���ϱ�";
            _HerCrying.gameObject.SetActive(false);
        }
    }
}