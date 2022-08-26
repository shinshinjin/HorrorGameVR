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
        _activeText = "��й�ȣ �Է��ϱ�";
    }
    public void Interaction()
    {
        if(_isActive == false)
        {
            StartCoroutine(UIManager.Instance.DrawDialogueText("�߰� �ձ� ��ư�� ������ �����ϴ�"));
            _isActive = true;
        }
        else
        {
            _isActive = false;
        }
        CofferOn.Invoke();
    }
}
