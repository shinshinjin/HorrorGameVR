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
}
