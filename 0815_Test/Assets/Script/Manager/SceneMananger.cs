using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMananger : MonoBehaviour
{
    private static SceneMananger _instance;

    public static SceneMananger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SceneMananger>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
