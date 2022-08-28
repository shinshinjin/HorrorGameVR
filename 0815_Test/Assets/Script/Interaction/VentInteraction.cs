using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentInteraction : MonoBehaviour, IInteraction
{
    public Transform Player;
    public Transform Target;
    public string _activeText;

    [SerializeField]
    private Rigidbody[] _ventRigid;
    private bool _isOpen;

    private void Awake()
    {
        _activeText = "����̹��� �ʿ��ϴ�";
        _ventRigid = GetComponentsInChildren<Rigidbody>();
    }

    private void Update()
    {
        if (ItemManager.Instance.CurrentItemName == "����̹�")
        {
            _activeText = "����̹��� ȯǳ�� ����";
        }
        else
        {
            _activeText = "����̹��� �ʿ��ϴ�";
        }

        if (_isOpen)
        {
            _activeText = "ȯǳ���� �����ϱ�";
        }
    }
    public void Interaction()
    {
        if (_isOpen)
        {
            Debug.Log("���� ���");
            Player.position = Target.position;
            UIManager.Instance.GuideText.text = "�������� �ܼ� ã��";
            GameManager.Instance.OffGYMap();
            gameObject.SetActive(false);
        }

        if (ItemManager.Instance.CurrentItemName == "����̹�")
        {
            for (int i = 0; i < _ventRigid.Length; i++)
            {
                _ventRigid[i].useGravity = true;
            }
            _isOpen = true;
        }
    }
}
