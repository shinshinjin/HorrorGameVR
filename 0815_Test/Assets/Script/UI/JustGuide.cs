using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustGuide : MonoBehaviour
{
    public string _guideText;

    private void Start()
    {
        UIManager.Instance.GuideText.text = _guideText;
    }
}
