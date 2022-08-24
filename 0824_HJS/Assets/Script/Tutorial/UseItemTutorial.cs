using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemTutorial : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(ItemManager.Instance.IsHaveTutorialKey)
        {
            UIManager.Instance.EraseInfoText();
            GameManager.Instance.IsInteractTutorialOver = true;
            GameManager.Instance.IsStartUseItemTutorial = true;
            gameObject.SetActive(false);
        }
        
    }
}
