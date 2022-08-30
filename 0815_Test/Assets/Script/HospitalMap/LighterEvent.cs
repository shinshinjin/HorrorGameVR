using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LighterEvent : MonoBehaviour
{
    [SerializeField]
    GameObject Lighter;
    public TherapyLightEventManager Therapy;
    public UnityEvent WaterOn;

    private void OnTriggerEnter(Collider other)
    {
        if(Therapy.Count == 3)
        {
            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("뭔가 이상하다.. 다른 방법이 있는걸까..?", 4f);
            WaterOn.Invoke();
        }
        if(other.tag == "Player")
        {
            Debug.Log("푸하하!!!");
            Lighter.SetActive(true);
            gameObject.SetActive(false);
            Therapy.Count++;
        }
    }

    
}
