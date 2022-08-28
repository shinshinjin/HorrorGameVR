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
        _activeText = "드라이버가 필요하다";
        _ventRigid = GetComponentsInChildren<Rigidbody>();
    }

    private void Update()
    {
        if (ItemManager.Instance.CurrentItemName == "드라이버")
        {
            _activeText = "드라이버로 환풍구 열기";
        }
        else
        {
            _activeText = "드라이버가 필요하다";
        }

        if (_isOpen)
        {
            _activeText = "환풍구로 진입하기";
        }
    }
    public void Interaction()
    {
        if (_isOpen)
        {
            Debug.Log("병원 출발");
            Player.position = Target.position;
            UIManager.Instance.GuideText.text = "병원에서 단서 찾기";
            GameManager.Instance.OffGYMap();
            gameObject.SetActive(false);
        }

        if (ItemManager.Instance.CurrentItemName == "드라이버")
        {
            for (int i = 0; i < _ventRigid.Length; i++)
            {
                _ventRigid[i].useGravity = true;
            }
            _isOpen = true;
        }
    }
}
