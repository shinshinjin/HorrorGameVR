using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamePlateInteraction : MonoBehaviour, IInteraction
{
    public GameObject[] _gameObject;

    public string _activeText;

    private void Awake()
    {
        _activeText = "비어 있음";
    }

    public void Interaction()
    {
        if (ItemManager.Instance.CurrentItemName == "누군가의 이름표")
        {
            _gameObject[0].SetActive(false);
            _gameObject[1].SetActive(true);
            _gameObject[2].SetActive(true);
            _activeText = "황준헌";
        }
    }
}
