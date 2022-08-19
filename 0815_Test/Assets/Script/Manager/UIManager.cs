using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public GameObject _interactText;
    public Text InteractText;
    public Text SelectedItemText;
    
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

    public void InteractDrawText(string text)
    {
        InteractText.text = text;
        
        _interactText.SetActive(true);
    }

    public void InteractEraseText()
    {
        _interactText.SetActive(false);
    }

    public void SetSelectedItemText(string itemName)
    {
        SelectedItemText.text = $"선택한 아이템 : {itemName}";
    }

}
