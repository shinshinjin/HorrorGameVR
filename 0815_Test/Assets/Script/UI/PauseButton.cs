using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public UserInput _input;

    public GameObject returnbutton;

    public void Pause_Game_End()
    {
        Debug.Log("∞‘¿” ¡æ∑· µ ");
        Application.Quit();
    }

    public void ReturnGame()
    {
        returnbutton.gameObject.SetActive(false);
        if(_input.IsInventoryOn == false)
        {
            GameManager.Instance.IsMouseLocked = true;
            GameManager.Instance.IsPaused = false;
        }
        _input.IsPauseOn = false;
    }
}
