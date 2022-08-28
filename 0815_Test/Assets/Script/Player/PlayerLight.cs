using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    private UserInput _input;
    private Light _light;

    private void Awake()
    {
        _input = GetComponentInParent<UserInput>();
        _light = GetComponent<Light>(); 
    }

    private void Update()
    {
        if(_input.IsLightOn)
        {
            _light.range = 40f;
        }
        else
        {
            _light.range = 1f;
        }
    }
}
