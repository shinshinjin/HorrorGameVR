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

    public GameObject TutorialTrigger;
    
    private void Update()
    {
        
        if(GameManager.Instance.IsMoveTutorialOver == false)
        {
            //TutorialTrigger.GetComponent<PlayerRay>().enabled = false;
            StartCoroutine(MoveTutorial());
            GameManager.Instance.IsMoveTutorialOver = true;
        }

        if (GameManager.Instance.IsInteractTutorialOver == false && GameManager.Instance.IsStartInteractTutorial)
        {
            StopAllCoroutines();
            StartCoroutine(InteractTutorial());
            GameManager.Instance.IsInteractTutorialOver = true;
        }

        if (GameManager.Instance.IsUseItemTutorialOver == false && GameManager.Instance.IsStartUseItemTutorial)
        {
            StopAllCoroutines();
            StartCoroutine(UseItemTutorial());
            GameManager.Instance.IsUseItemTutorialOver = true;
        }

        if(GameManager.Instance.IsTutorialOver)
        {
            StopAllCoroutines();
            StartCoroutine(TutorialOver());
            GameManager.Instance.IsTutorialOver = false;
        }


    }
    IEnumerator MoveTutorial()
    {
        for(int i = 0; i < MoveTutorialText.Length; i++)
        {
            StartCoroutine(UIManager.Instance.DrawInfoText(MoveTutorialText[i]));
            yield return new WaitForSeconds(3f);
        }
        GameManager.Instance.IsInteractTutorialOver = false;
        GameManager.Instance.IsPaused = false;
        TutorialTrigger.GetComponent<PlayerRay>().enabled = true;
    }

    IEnumerator InteractTutorial()
    {
        for (int i = 0; i < InteractTutorialText.Length; i++)
        {
            StartCoroutine(UIManager.Instance.DrawInfoText(InteractTutorialText[i]));
            yield return new WaitForSeconds(3f);
        }
        GameManager.Instance.IsUseItemTutorialOver = false;
    }

    IEnumerator UseItemTutorial()
    {
        for (int i = 0; i < UseItemTutorialText.Length; i++)
        {
            StartCoroutine(UIManager.Instance.DrawInfoText(UseItemTutorialText[i]));
            yield return new WaitForSeconds(3f);
        }
    }

    IEnumerator TutorialOver()
    {
        for (int i = 0; i < TutorialOverText.Length; i++)
        {
            StartCoroutine(UIManager.Instance.DrawInfoText(TutorialOverText[i]));
            yield return new WaitForSeconds(3f);
        }
    }
}
