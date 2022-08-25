using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamProjectInteraction : MonoBehaviour, IInteraction
{
    public string _activeText;

    private Light _light;

    public bool _isBeamOn;

    private void Awake()
    {
        _activeText = "빔 프로젝트 켜기";
        _light = GetComponentInChildren<Light>();
        _light.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (ItemManager.Instance.CurrentItemName == "빔 프로젝트 리모컨" && _isBeamOn == false)
        {
            _activeText = "리모컨으로 빔 프로젝터를 켠다";
        }
        else if(_isBeamOn)
        {
            _activeText = "빔 프로젝트가 켜져있다";
        }
        else
        {
            _activeText = "리모컨이 필요하다";
        }
    }
    public void Interaction()
    {
        if(_isBeamOn == false && ItemManager.Instance.CurrentItemName == "빔 프로젝트 리모컨")
        {
            _isBeamOn = true;
            _light.gameObject.SetActive(true);
        }
    }
}
