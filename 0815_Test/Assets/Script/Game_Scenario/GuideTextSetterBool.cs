using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTextSetterBool : MonoBehaviour
{
    public bool GuideTextStart;

    public string GuideText;
    private void OnTriggerStay(Collider other)
    {
        if(GuideTextStart)
        {
            UIManager.Instance.GuideText.text = GuideText;
            gameObject.SetActive(false);
        }
    }
}
