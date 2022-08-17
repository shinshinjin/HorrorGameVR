using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public GameObject _text;
    public Text Text;
    
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


    public void InteractDrawText(string text, bool isInteract)
    {
        Text.text = text;
        if(isInteract)
        {
            _text.SetActive(true);
        }
        else
        {
            _text.SetActive(false);
        }
    }
}
