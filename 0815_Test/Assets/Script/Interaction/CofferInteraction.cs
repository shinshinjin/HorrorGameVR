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
        _activeText = "열쇠가 필요하다";
    }
    private void Update()
    {
        if(ItemManager.Instance.CurrentItemName == "스크린 금고 열쇠")
        {
            _activeText = "열쇠로 연다";
        }
        else
        {
            _activeText = "열쇠가 필요하다";
        }
    }
    public void Interaction()
    {
        if (ItemManager.Instance.CurrentItemName == "스크린 금고 열쇠")
        {
            ItemManager.Instance.UsedItem();
            gameObject.SetActive(false);
        }
    }
}
