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

    private bool isLightOff = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            isLightOff = true;
            Debug.Log("응급실 유지");
            Doctor.gameObject.SetActive(true);
            _light_source.gameObject.GetComponent<Light>().color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(Doctor.gameObject, 2f);
        Destroy(Light.gameObject, 2f);
        gameObject.SetActive(false);
        StopAllCoroutines();
    }

    void LightOff()
    {
        if (isLightOff == true)
        {
            Light.SetActive(false);
        }
    }

    void LightOn()
    {
        if (isLightOff == false)
        {
            Light.SetActive(true);
        }
    }
}
