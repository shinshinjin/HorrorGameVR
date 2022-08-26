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

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("���޽� ����");
            Doctor.gameObject.SetActive(true);
            _light_source.gameObject.GetComponent<Light>().color = Color.red;
        }
    }

    private void OnTriggerExit()
    {
        Destroy(Doctor.gameObject, 2f);
        Destroy(Light.gameObject, 2f);
        gameObject.SetActive(false);
    }
}
