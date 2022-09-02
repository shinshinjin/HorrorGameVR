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
        _activeText = "��й�ȣ �Է��ϱ�";
    }
    public void Interaction()
    {
        if(IsActive == false)
        {
            StartCoroutine(UIManager.Instance.DrawDialogueText("�߰� �ձ� ��ư�� ������ �����ϴ�"));
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
