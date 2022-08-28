using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public Transform Player;
    public GameObject GYMap;
    public GameObject HospitalMap;

    public bool IsMouseLocked = true;

    public bool IsTutorialOver;

    public bool IsPaused;

    public bool IsMoveTutorialOver;

    public bool IsStartInteractTutorial;
    public bool IsInteractTutorialOver;

    public bool IsStartUseItemTutorial;
    public bool IsUseItemTutorialOver;

    public bool IsInFan;

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

    public void PlaySoundFromPlayer(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Player.position);
    }

    public void OffGYMap()
    {
        GYMap.SetActive(false);
    }

}
