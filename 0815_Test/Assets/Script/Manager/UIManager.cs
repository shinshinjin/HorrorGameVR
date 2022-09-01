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
    public Text InfoText;
    public GameObject DialogueUI;
    public Text Dialogue;
    public Text GuideText;
    public Text SelectedItemTextWithInventory;

    public Image BackGroundImage;
    public GameObject BackGroundUI;

    private float _drawOneWordTime = 0.02f;
    
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
    public void EraseInfoText()
    {
        InfoText.text = "";
    }

    public IEnumerator DrawInfoText(string infoText)
    {
        InfoText.text = "";
        for (int i = 0; i < infoText.Length; i++)
        {
            InfoText.text += infoText[i];
            yield return new WaitForSeconds(_drawOneWordTime);
        }
    }

    public void SetAndDrawGuideText(string guideText)
    {
        GuideText.text = guideText;
    }
    public void EraseGuideText()
    {
        GuideText.text = "";
    }
    /// <summary>
    /// 대사 띄우기와 N초후에 지우기 합쳐놓은 함수
    /// </summary>
    /// <param name="dialogue">대사</param>
    /// <param name="seconds">이 시간 후에 대사 지움</param>
    public void DrawAndEraseDialogueTextForSeconds(string dialogue, float seconds)
    {
        StartCoroutine(DrawDialogueText(dialogue));
        StartCoroutine(EraseDialogueTextSeconds(seconds));
    }

    public IEnumerator EraseDialogueTextSeconds(float seconds)
    {
        if(DialogueUI.activeInHierarchy == false)
        {
            StopCoroutine(EraseDialogueTextSeconds(seconds));
        }
        yield return new WaitForSeconds(seconds);
        DialogueUI.SetActive(false);
        
    }

    public void EraseDialogueText()
    {
        DialogueUI.SetActive(false);
    }

    public IEnumerator DrawDialogueText(string dialogue)
    {
        DialogueUI.SetActive(true);
        Dialogue.text = "";
        for (int i = 0; i < dialogue.Length; i++)
        {
            Dialogue.text += dialogue[i];
            yield return new WaitForSeconds(_drawOneWordTime);
        }
    }
    /// <summary>
    /// 페이드 인 & 아웃에 쓸 배경 이미지 색 세팅 함수
    /// </summary>
    /// <param name="color"> 배경의 색 </param>
    public void SetBackGroundColor(Color color)
    {
        BackGroundImage.color = color;
    }
    /// <summary>
    /// 화면 페이드 인 코루틴
    /// </summary>
    /// <param name="fadeInTime">0.1초마다 빼 줄 알파 값, 0 ~ 1 사이 작을수록 더 천천히 투명해짐</param>
    /// <returns></returns>
    public IEnumerator FadeInBackGround(float fadeInTime)
    {
        Color FadeInColor = BackGroundImage.color;
        FadeInColor.a = 1f;
        BackGroundImage.color = FadeInColor;
        BackGroundUI.SetActive(true);
        while (FadeInColor.a >= 0f)
        {
            FadeInColor.a -= fadeInTime;
            BackGroundImage.color = FadeInColor;

            yield return new WaitForSeconds(0.01f);
        }
        BackGroundUI.SetActive(false);
    }
    /// <summary>
    /// 화면 페이드 아웃 코루틴
    /// </summary>
    /// <param name="fadeOutTime">0.1초마다 더해 줄 알파 값, 0 ~ 1 사이 작을수록 더 천천히 불투명해짐</param>
    /// <returns></returns>
    public IEnumerator FadeOutBackGround(float fadeOutTime)
    {
        Color FadeOutColor = BackGroundImage.color;
        BackGroundUI.SetActive(true);
        while (FadeOutColor.a <= 1f)
        {
            FadeOutColor.a += fadeOutTime;
            BackGroundImage.color += FadeOutColor;

            yield return new WaitForSeconds(0.01f);
        }
        BackGroundUI.SetActive(false);
    }

    /// <summary>
    /// 페이드 인, 아웃을 동시에 수행하는 코루틴
    /// </summary>
    /// <param name="fadeInTime">0.1초마다 빼 줄 알파 값, 0 ~ 1 사이 작을수록 더 천천히 투명해짐</param>
    /// <param name="fadeOutTime">0.1초마다 더해 줄 알파 값, 0 ~ 1 사이 작을수록 더 천천히 불투명해짐</param>
    /// <returns></returns>
    public IEnumerator FadeOutAndIn(float fadeInTime, float fadeOutTime)
    {
        Color FadeOutColor;
        FadeOutColor = BackGroundImage.color;
        FadeOutColor.a = 0f;
        BackGroundUI.SetActive(true);
        while (BackGroundImage.color.a <= 1f)
        {

            FadeOutColor.a += fadeOutTime;
            BackGroundImage.color = FadeOutColor;

            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2f);
        while (BackGroundImage.color.a >= 0f)
        {
            FadeOutColor.a -= fadeInTime;
            BackGroundImage.color = FadeOutColor;

            yield return new WaitForSeconds(0.01f);
        }
        BackGroundUI.SetActive(false);
    }
}
