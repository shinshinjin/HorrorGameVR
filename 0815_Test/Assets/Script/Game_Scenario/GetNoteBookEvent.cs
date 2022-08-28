using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNoteBookEvent : MonoBehaviour
{
    public GameObject Lights;
    public DoorInteraction MainDoor;
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
            if(MainDoor.IsOpen == false) { 
            
                MainDoor.IsOpen = true;
                StartCoroutine(MainDoor.Open());
            }
        }
    }
    private void AllLightOff()
    {
        Lights.SetActive(false);
        UIManager.Instance.DrawAndEraseDialogueTextForSeconds("��..���? ���Ⱑ �����ǰ�? ���� � ���߰ھ�...", 4f);
    }

    
}
