using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour, IInteraction
{
    public GameObject[] _gameObject;

    public string _activeText;

    private void Awake()
    {
        _activeText = "박스 조지기";
    }

    public void Interaction()
    {
        Debug.Log("조져버렸다...");
        _gameObject[0].SetActive(true);
        _gameObject[1].SetActive(false);
    }
}
