using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NumberCofferInteraction : MonoBehaviour
{
    public UnityEvent CofferOn;

    public string _activeText;

    public bool IsActive;

    private Image _image;
    private void Awake()
    {
        _image = GetComponent<Image>();
        _activeText = "비밀번호 입력하기";
    }
    public void Interaction()
    {
        if(IsActive == false)
        {
            StartCoroutine(UIManager.Instance.DrawDialogueText("중간 둥근 버튼을 누르면 나갑니다"));
            IsActive = true;
            GameManager.Instance.IsCofferOn = true;
        }
        //else
        //{
        //    IsActive = false;
        //    GameManager.Instance.IsCofferOn = false;
        //}
        CofferOn.Invoke();
    }
}
