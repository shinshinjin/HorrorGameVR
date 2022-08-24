using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTextManager : MonoBehaviour
{
    [SerializeField]
    private GuideTextSetterBool[] _guideTextBoolean;

    private void Awake()
    {
        _guideTextBoolean = GetComponentsInChildren<GuideTextSetterBool>();
    }

    private void Update()
    {
        if(ItemManager.Instance.IsHaveNoteBook)
        {
            _guideTextBoolean[0].GuideTextStart = true;
        }
    }
}
