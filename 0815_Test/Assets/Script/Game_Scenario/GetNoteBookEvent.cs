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
        UIManager.Instance.DrawAndEraseDialogueTextForSeconds("어..어라? 전기가 나간건가? 집에 어서 가야겠어...", 4f);
    }

    
}
