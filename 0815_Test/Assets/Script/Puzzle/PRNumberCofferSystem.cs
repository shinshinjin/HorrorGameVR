using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PRNumberCofferSystem : MonoBehaviour
{
    public GameObject CofferImage;
    public NumberCofferInteraction Coffer;

    public GameObject[] Coffers;
    public UserInput _input;
    public AudioSource Audio;
    public Text InputNumber;

    private string _correctNumber = "0622";

    public void CofferOff()
    {
        UIManager.Instance.EraseDialogueText();
        Coffer.IsActive = false;
        GameManager.Instance.IsCofferOn = false;
        if (_input.IsPauseOn == false && _input.IsInventoryOn == false && GameManager.Instance.IsCofferOn == false)
        {
            GameManager.Instance.IsMouseLocked = true;
            GameManager.Instance.IsPaused = false;
        }
        CofferImage.SetActive(false);
    }
    public void CofferOn()
    {
        if (Coffer.IsActive)
        {
            GameManager.Instance.IsMouseLocked = false;
            GameManager.Instance.IsPaused = true;
            CofferImage.SetActive(true);
        }
    }

    public void PlayButtonSound()
    {
        Audio.Play();
    }

    public void SetInputNumber(string number)
    {
        InputNumber.text += number;
    }

    public void CompareNumber()
    {
        if(_correctNumber == InputNumber.text)
        {
            Coffer.GetComponent<BoxCollider>().enabled = false;
            Coffers[0].SetActive(true);
            Coffers[1].SetActive(false);
            Coffer.IsActive = false;
            CofferOff();
        }
        else
        {
            InputNumber.text = "";
        }
    }

}
