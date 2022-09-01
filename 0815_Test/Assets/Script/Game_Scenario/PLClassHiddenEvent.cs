using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLClassHiddenEvent : MonoBehaviour
{
    public Transform Player;
    public Transform Return;

    public AudioClip WomenShout;
    public AudioClip WomenSad;
    public AudioClip Machine;
    public AudioClip DoctorLaugh;
    public AudioClip HeartBeat;


    private AudioSource _audio;
    private bool boom;


    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    public void HiddenEventStart()
    {
        if(boom == false)
        {
            MovingMoving();
            boom = true;    
        }
        
    }
    public void MovingMoving()
    {
        GameManager.Instance.IsPaused = true;
        Player.rotation = transform.rotation;
        Player.position = transform.position;
        StartCoroutine(Event());
    }

    public IEnumerator Event()
    {

        _audio.PlayOneShot(WomenSad);
        _audio.PlayOneShot(HeartBeat);
        _audio.PlayOneShot(DoctorLaugh);
        yield return new WaitForSeconds(10f);
        _audio.PlayOneShot(Machine);
        yield return new WaitForSeconds(1f);
        _audio.PlayOneShot(DoctorLaugh);
        yield return new WaitForSeconds(0.5f);
        _audio.PlayOneShot(WomenShout);
        UIManager.Instance.SetBackGroundColor(Color.red);
        FadeInOut();
        yield return new WaitForSeconds(2.5f);
        Player.rotation = Return.rotation;
        Player.transform.position = Return.position;
        yield return new WaitForSeconds(3f);
        GameManager.Instance.IsPaused = false;
        UIManager.Instance.DrawAndEraseDialogueTextForSeconds("바...방금 그건 대체...", 3f);
        gameObject.SetActive(false);
    }

    private void FadeInOut()
    {
        StartCoroutine(UIManager.Instance.FadeOutAndIn(0.01f, 0.01f));
    }
}
