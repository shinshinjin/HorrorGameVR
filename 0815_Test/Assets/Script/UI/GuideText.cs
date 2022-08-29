using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideText : MonoBehaviour
{
    public string _GuideText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UIManager.Instance.GuideText.text = _GuideText;
        }
    }
}
