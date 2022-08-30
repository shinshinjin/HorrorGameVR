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
            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("���� �̻��ϴ�.. �ٸ� ����� �ִ°ɱ�..?", 4f);
            WaterOn.Invoke();
        }
        if(other.tag == "Player")
        {
            Debug.Log("Ǫ����!!!");
            Lighter.SetActive(true);
            gameObject.SetActive(false);
            Therapy.Count++;
        }
    }

    
}
