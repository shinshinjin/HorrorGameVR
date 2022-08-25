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
    public Text GuideText;
    public Text SelectedItemTextWithInventory;
    
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
        SelectedItemText.text = itemName;
        SelectedItemTextWithInventory.text = itemName;
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

    public void SetAndDrawGuideText(string guideText)
    {
        GuideText.text = guideText;
    }
    public void EraseGuideText()
    {
        GuideText.text = "";
    }


}
