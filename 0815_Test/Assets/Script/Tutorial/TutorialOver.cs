using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialOver : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(ItemManager.Instance.IsHavePhone)
        {
            UIManager.Instance.EraseInfoText();
            GameManager.Instance.IsTutorialOver = true;
            gameObject.SetActive(false);
        }
    }
}
