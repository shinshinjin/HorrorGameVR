using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NumberCofferInteraction : MonoBehaviour
{
    public UnityEvent CofferOn;

    public string _activeText;

    public bool _isActive;

    private Image _image;
    private void Awake()
    {
        _image = GetComponent<Image>();
        _activeText = "비밀번호 입력하기";
    }
    public void Interaction()
    {
        if(_isActive == false)
        {
            StartCoroutine(UIManager.Instance.DrawDialogueText("중간 둥근 버튼을 누르면 나갑니다"));
            _isActive = true;
        }
        else
        {
            _isActive = false;
        }
        CofferOn.Invoke();
    }
}
