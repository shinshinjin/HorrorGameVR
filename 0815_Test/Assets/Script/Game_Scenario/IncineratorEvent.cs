using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IncineratorEvent : MonoBehaviour, IInteraction
{
    public UnityEvent BurningBrain;
    public GameObject StorageKey;
    public GameObject _HerCrying;

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
            ItemManager.Instance.UsedItem();
            _audio.Play();
            _isBrainIn = true;
        }

        if (ItemManager.Instance.CurrentItemName == "라이터" && _isBrainIn)
        {
            ItemManager.Instance.UsedItem();
            _audio.Play();
            StorageKey.SetActive(true);
            BurningBrain.Invoke();
            UIManager.Instance.GuideText.text = "병원 탈출하기";
            _HerCrying.gameObject.SetActive(false);
        }
    }
}
