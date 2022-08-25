using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoWayText : MonoBehaviour
{
    [SerializeField]
    private string ThisNotWay;

    private void OnTriggerStay()
    {
        UIManager.Instance.SetInfoText(ThisNotWay);
        UIManager.Instance.DrawInfoText();
    }

    private void OnTriggerExit()
    {
        UIManager.Instance.EraseInfoText();
    }
}
