using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningBrainEvent : MonoBehaviour
{
    public string SetText;

    private void OnTriggerEnter(Collider other)
    {
        if(ItemManager.Instance.IsHaveLighter && other.CompareTag("Player"))
        {
            UIManager.Instance.DrawInfoText(SetText);
        }
    }
}
