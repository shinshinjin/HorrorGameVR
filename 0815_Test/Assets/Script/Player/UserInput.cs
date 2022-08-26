using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float InputX;
    public float InputY;

    public float MouseInputX;
    public float MouseInputY;
    [SerializeField]
    public bool IsLightOn;
    public bool IsInventoryOn;

    private AudioSource _handLightSound;
    public AudioClip HandLightSound;

    private void Awake()
    {
        _handLightSound = GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {

        InputX = Input.GetAxisRaw("Horizontal");
        InputY = Input.GetAxisRaw("Vertical");

        MouseInputX = Input.GetAxis("Mouse X");
        MouseInputY = Input.GetAxis("Mouse Y");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && ItemManager.Instance.IsHavePhone)
        {
            IsLightOn = !IsLightOn;
            _handLightSound.PlayOneShot(HandLightSound);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            IsInventoryOn = !IsInventoryOn;
            if (IsInventoryOn)
                StartCoroutine(UIManager.Instance.DrawDialogueText("인벤토리가 켜졌습니다"));
            else
                UIManager.Instance.UnVisibleDialogueText();
        }
    }
}
