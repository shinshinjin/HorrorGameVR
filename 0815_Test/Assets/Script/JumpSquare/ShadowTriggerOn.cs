using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowTriggerOn : MonoBehaviour
{
    public GameObject _ShadowEventOn;

    private void Start()
    {
        _ShadowEventOn.SetActive(true);
    }
}
