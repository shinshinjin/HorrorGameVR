using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "End")
        {
            Application.Quit();
            //SceneManager.LoadScene("TitleScene");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
