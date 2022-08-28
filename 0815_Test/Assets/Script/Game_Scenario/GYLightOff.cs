using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GYLightOff : MonoBehaviour
{
    public GameObject Lights;

    private BoxCollider _boxCollider;

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(ItemManager.Instance.IsHaveNoteBook)
        {
            AllLightOff();
            _boxCollider.enabled = false;
        }
    }
    private void AllLightOff()
    {
        Lights.SetActive(false);
        StartCoroutine(UIManager.Instance.DrawDialogueText("어..어라? 전기가 나간건가? 집에 어서 가야겠어..."));
        StartCoroutine(UIManager.Instance.EraseDialogueTextSeconds(4f));
    }
}
