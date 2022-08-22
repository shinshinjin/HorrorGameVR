using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public bool IsMouseLocked = true;

    public bool IsTutorialOver;

    public bool IsPaused;

    public bool IsMoveTutorialOver;

    public bool IsStartInteractTutorial;
    public bool IsInteractTutorialOver;

    public bool IsStartUseItemTutorial;
    public bool IsUseItemTutorialOver;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>(); 
            }
            return _instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    
}
