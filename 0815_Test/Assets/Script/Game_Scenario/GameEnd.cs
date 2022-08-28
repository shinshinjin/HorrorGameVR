using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {     
        Debug.Log("∞‘¿” ≥°");
        SceneManager.LoadScene(2);
    }
}
