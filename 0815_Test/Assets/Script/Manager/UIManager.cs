using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public GameObject ViewInteractText;
    public Text InteractText;
    public Text SelectedItemText;
    public GameObject ViewInfoText;
    public Text InfoText;
    
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void DrawInteractText(string text)
    {
        InteractText.text = text;

        ViewInteractText.SetActive(true);
    }

    public void EraseInteractText()
    {
        ViewInteractText.SetActive(false);
    }

    public void SetSelectedItemText(string itemName)
    {
        SelectedItemText.text = $"선택한 아이템 : {itemName}";
    }

    public void DrawInfoText()
    {
        ViewInfoText.SetActive(true);
    }

    public void EraseInfoText()
    {
        ViewInfoText.SetActive(false);
    }

    public void SetInfoText(string infoText)
    {
        InfoText.text = infoText;
    }

}
