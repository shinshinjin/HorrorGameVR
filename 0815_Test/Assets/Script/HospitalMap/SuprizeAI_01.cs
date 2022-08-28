using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuprizeAI_01 : MonoBehaviour
{
    [SerializeField]
    GameObject Doctor;
    [SerializeField]
    GameObject Light;
    [SerializeField]
    Light _light_source;
    [SerializeField]
    GameObject _audio_Object;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("응급실 나감");
            Doctor.gameObject.SetActive(true);
            _light_source.gameObject.GetComponent<Light>().color = Color.red;
            _audio_Object.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit()
    {
        Destroy(Doctor.gameObject, 2f);
        Destroy(Light.gameObject, 2f);
        gameObject.SetActive(false);
        _audio_Object.SetActive(false);
    }
}
