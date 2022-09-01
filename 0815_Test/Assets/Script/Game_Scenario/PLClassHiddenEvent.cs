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
    public AudioClip ScareSound;

    public GameObject Emergency;

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
            Emergency.SetActive(false);
            MovingMoving();
            boom = true;    
        }
        
    }
    public void MovingMoving()
    {
        GameManager.Instance.DoNotInput = true;
        StartCoroutine(FirstEvent());
    }

    public IEnumerator FirstEvent()
    {
        _audio.PlayOneShot(ScareSound);
        StartCoroutine(UIManager.Instance.DrawInfoText("HELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELLHELL"));
        UIManager.Instance.SetAndDrawGuideText("?????????");
        UIManager.Instance.DrawAndEraseDialogueTextForSeconds("내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게내과거를보여줄게", 5f);
        yield return new WaitForSeconds(5f);
        for (int i = 0; i < 5; i++)
        {
            Player.GetComponent<UserInput>().IsLightOn = !Player.GetComponent<UserInput>().IsLightOn;
            yield return new WaitForSeconds(0.3f);
        }
        Player.rotation = transform.rotation;
        Player.position = transform.position;
        StartCoroutine(MainEvent());
    }
    public IEnumerator MainEvent()
    {
        UIManager.Instance.EraseInfoText();
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
        yield return new WaitForSeconds(2.8f);
        Player.rotation = Return.rotation;
        Player.transform.position = Return.position;
        UIManager.Instance.EraseGuideText();
        UIManager.Instance.SetAndDrawGuideText("병원..으로 가자..");
        yield return new WaitForSeconds(2.5f);
        GameManager.Instance.DoNotInput = false;
        UIManager.Instance.DrawAndEraseDialogueTextForSeconds("바...방금 그건 대체...", 3f);
        Emergency.SetActive(true);
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }

    private void FadeInOut()
    {
        StartCoroutine(UIManager.Instance.FadeOutAndIn(0.01f, 0.01f));
    }
}
