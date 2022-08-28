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

    public string ActiveText;

    private AudioSource _audio;

    private bool _isBrainIn;


    private void Update()
    {

        if(ItemManager.Instance.CurrentItemName == "그녀의 뇌")
        {
            ActiveText = "뇌를 넣는다";
        }
        else if(ItemManager.Instance.CurrentItemName == "라이터" && _isBrainIn)
        {
            ActiveText = "불을 붙인다";
        }
        else if(ItemManager.Instance.CurrentItemName == "라이터" && _isBrainIn == false)
        {
            ActiveText = "태울것을 먼저 넣자";
        }
        else
        {
            ActiveText = "무언가 태울 수 있을 것 같다...";
        }




    }

    public void Interaction()
    {
        if (ItemManager.Instance.CurrentItemName == "그녀의 뇌")
        {
            _isBrainIn = true;
        }

        if (ItemManager.Instance.CurrentItemName == "라이터" && _isBrainIn)
        {
            StorageKey.SetActive(true);
            BurningBrain.Invoke();
            UIManager.Instance.GuideText.text = "병원 탈출하기";
        }
    }
}
