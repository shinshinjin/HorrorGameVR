using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTextSetter : MonoBehaviour
{
    public string GuideText;

    private void OnTriggerEnter(Collider other)
    {
        UIManager.Instance.GuideText.text = GuideText;
        gameObject.SetActive(false);
    }

}
