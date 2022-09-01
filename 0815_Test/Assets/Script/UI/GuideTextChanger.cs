using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTextChanger : MonoBehaviour
{
    public string _GuideText;

    private void Start()
    {
        UIManager.Instance.GuideText.text = _GuideText;
    }
}
