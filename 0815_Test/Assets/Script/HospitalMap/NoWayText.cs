using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NoWayText : MonoBehaviour
{
    private string _NowayText;

    public UnityEvent InteractSwitch;
    private bool OnlyOneTime;

    private void OnTriggerEnter()
    {
        if(OnlyOneTime == false)
        {
            _NowayText = "이곳은 어두워서 무서워... 다른길을 찾아보자.";
            StartCoroutine(UIManager.Instance.DrawDialogueText(_NowayText));
        }
        OnlyOneTime = true;  
        
    }

    private void OnTriggerStay()
    {
        _NowayText = "";
    }

    private void OnTriggerExit()
    {
        OnlyOneTime = false;
        UIManager.Instance.EraseDialogueText();
    }
}
