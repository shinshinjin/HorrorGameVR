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
        StartCoroutine(UIManager.Instance.DrawDialogueText("��..���? ���Ⱑ �����ǰ�? ���� � ���߰ھ�..."));
        StartCoroutine(UIManager.Instance.EraseDialogueTextSeconds(4f));
    }
}
