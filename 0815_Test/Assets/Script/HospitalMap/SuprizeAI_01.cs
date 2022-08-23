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
    Light _light;

    private bool isLightOff = false;

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            isLightOff = true;

            Doctor.gameObject.SetActive(true);
            _light.gameObject.GetComponent<Light>().color = Color.red;
            Destroy(Doctor.gameObject, 2f);
            Destroy(Light.gameObject, 2f);
        }
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
