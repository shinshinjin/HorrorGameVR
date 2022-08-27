using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPauseOnOff : MonoBehaviour
{
    public UserInput _input;

    public GameObject Pause;

    //public NumberCofferInteraction Coffer;

    private void Start()
    {
        Pause.SetActive(false);
    }
    public void PauseOnOffFunc()
    {
        Pause.SetActive(_input.IsPauseOn);
        if (_input.IsPauseOn)
        {
            GameManager.Instance.IsMouseLocked = false;
            GameManager.Instance.IsPaused = true;
        }

        else
        {
            GameManager.Instance.IsMouseLocked = true;
            GameManager.Instance.IsPaused = false;
        }
    }
}
