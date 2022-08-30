using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamProjectInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;
    public bool _isBeamOn;

    private Light _light;
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _activeText = "�� ������Ʈ �ѱ�";
        _light = GetComponentInChildren<Light>();
        _light.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (ItemManager.Instance.CurrentItemName == "�� ������Ʈ ������" && _isBeamOn == false)
        {
            _activeText = "���������� �� �������͸� �Ҵ�";
        }
        else if(_isBeamOn)
        {
            _activeText = "�� ������Ʈ�� �����ִ�";
        }
        else
        {
            _activeText = "�������� �ʿ��ϴ�";
        }
    }
    public void Interaction()
    {
        if(_isBeamOn == false && ItemManager.Instance.CurrentItemName == "�� ������Ʈ ������")
        {
            _audio.Play();
            _isBeamOn = true;
            _light.gameObject.SetActive(true);
        }
    }
}
