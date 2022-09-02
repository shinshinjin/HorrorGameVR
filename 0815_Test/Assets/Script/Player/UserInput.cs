using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UserInput : MonoBehaviour
{
    public UnityEvent InventoryOn;
    public UnityEvent PauseOn;
    public float InputX;
    public float InputY;

    public float MouseInputX;
    public float MouseInputY;
    [SerializeField]
    public bool IsLightOn;
    public bool IsInventoryOn;
    public bool IsPauseOn;
    

    private AudioSource _handLightSound;
    public AudioClip HandLightSound;

    private void Awake()
    {
        _handLightSound = GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (GameManager.Instance.DoNotInput == false)
        {
            InputX = Input.GetAxisRaw("Horizontal");
            InputY = Input.GetAxisRaw("Vertical");

            MouseInputX = Input.GetAxis("Mouse X");
            MouseInputY = Input.GetAxis("Mouse Y");
        }
        else
        {
            InputX = 0;
            InputY = 0;

            MouseInputX = 0;
            MouseInputY = 0;
        }
        
    }

    private void Update()
    {
        if(GameManager.Instance.DoNotInput == false)
        {
            if (Input.GetKeyDown(KeyCode.F) && ItemManager.Instance.IsHavePhone)
            {
                IsLightOn = !IsLightOn;
                _handLightSound.PlayOneShot(HandLightSound);
            }

            if (Input.GetKeyDown(KeyCode.Tab))
            {
                IsInventoryOn = !IsInventoryOn;
                InventoryOn.Invoke();
                //if (IsInventoryOn)
                //    StartCoroutine(UIManager.Instance.DrawDialogueText("인벤토리가 켜졌습니다"));
                //else
                //    UIManager.Instance.UnVisibleDialogueText();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                IsPauseOn = !IsPauseOn;
                PauseOn.Invoke();
            }
        }
        
    }
}
