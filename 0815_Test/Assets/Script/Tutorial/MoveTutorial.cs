using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTutorial : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UIManager.Instance.EraseInfoText();
        GameManager.Instance.IsMoveTutorialOver = true;
        GameManager.Instance.IsStartInteractTutorial = true;
        gameObject.SetActive(false);
    }
}
