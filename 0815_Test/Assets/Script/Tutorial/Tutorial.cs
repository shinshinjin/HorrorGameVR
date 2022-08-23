using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField]
    private string[] MoveTutorialText;
    [SerializeField]
    private string[] InteractTutorialText;
    [SerializeField]
    private string[] UseItemTutorialText;
    [SerializeField]
    private string[] TutorialOverText;

    
    private void Update()
    {
        
        if(GameManager.Instance.IsMoveTutorialOver == false)
        {
            StartCoroutine(MoveTutorial());
            GameManager.Instance.IsMoveTutorialOver = true;
            UIManager.Instance.DrawInfoText();
        }

        if (GameManager.Instance.IsInteractTutorialOver == false && GameManager.Instance.IsStartInteractTutorial)
        {
            StartCoroutine(InteractTutorial());
            GameManager.Instance.IsInteractTutorialOver = true;
            UIManager.Instance.DrawInfoText();
        }

        if (GameManager.Instance.IsUseItemTutorialOver == false && GameManager.Instance.IsStartUseItemTutorial)
        {
            StartCoroutine(UseItemTutorial());
            GameManager.Instance.IsUseItemTutorialOver = true;
            UIManager.Instance.DrawInfoText();
        }

        if(GameManager.Instance.IsTutorialOver)
        {
            StartCoroutine(TutorialOver());
            UIManager.Instance.DrawInfoText();
            GameManager.Instance.IsTutorialOver = false;
        }


    }
    IEnumerator MoveTutorial()
    {
        for(int i = 0; i < MoveTutorialText.Length; i++)
        {
            UIManager.Instance.SetInfoText(MoveTutorialText[i]);
            yield return new WaitForSeconds(1f);
        }
        GameManager.Instance.IsInteractTutorialOver = false;
    }

    IEnumerator InteractTutorial()
    {
        for (int i = 0; i < InteractTutorialText.Length; i++)
        {
            UIManager.Instance.SetInfoText(InteractTutorialText[i]);
            yield return new WaitForSeconds(1f);
        }
        GameManager.Instance.IsUseItemTutorialOver = false;
    }

    IEnumerator UseItemTutorial()
    {
        for (int i = 0; i < UseItemTutorialText.Length; i++)
        {
            UIManager.Instance.SetInfoText(UseItemTutorialText[i]);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator TutorialOver()
    {
        for (int i = 0; i < TutorialOverText.Length; i++)
        {
            UIManager.Instance.SetInfoText(TutorialOverText[i]);
            yield return new WaitForSeconds(1f);
        }
    }
}
