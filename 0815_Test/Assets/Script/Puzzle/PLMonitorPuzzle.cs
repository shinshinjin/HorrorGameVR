using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLMonitorPuzzle : MonoBehaviour
{
    public GameObject Class12Key;

    public AudioClip DropKey;

    [SerializeField]
    private MonitorInteraction[] Monitor;

    private int[] _correctOnMonitorNumber = new int[18] { 0, 4, 9, 12, 14, 15, 13, 16, 17, 18, 19, 20, 24, 26, 27, 21, 25, 28 };
    private int[] _correctOffMonitorNumber = new int[14] { 1, 2, 3, 6, 7, 5, 8, 11, 10, 22, 23, 30, 31, 29 };

    [SerializeField]
    private bool _PLClassPuzzleMonitorOnCorrect;
    [SerializeField]
    private bool _PLClassPuzzleMonitorOffCorrect;

    private void Awake()
    {
        Monitor = GetComponentsInChildren<MonitorInteraction>();
    }

    public void PLMonitorStatChange()
    {
        
        for (int i = 0; i < _correctOnMonitorNumber.Length; i++) 
        {
            if (Monitor[_correctOnMonitorNumber[i]]._isScreenOn)
            {
                _PLClassPuzzleMonitorOnCorrect = true;
            }
            else
            {
                _PLClassPuzzleMonitorOnCorrect = false;
                break;
            }
        }

        for (int i = 0; i < _correctOffMonitorNumber.Length; i++)
        {
            if (Monitor[_correctOffMonitorNumber[i]]._isScreenOn == false)
            {
                _PLClassPuzzleMonitorOffCorrect = true;
            }
            else
            {
                _PLClassPuzzleMonitorOffCorrect = false;
                break;
            }
        }

        if(_PLClassPuzzleMonitorOnCorrect && _PLClassPuzzleMonitorOffCorrect)
        {
            Debug.Log("ÆÛÁñ Àß ÀÛµ¿µÊ");
            GameManager.Instance.PlaySoundFromPlayer(DropKey);
            Class12Key.SetActive(true);
            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("¾Õ¿¡¼­ ¹«¾ð°¡ ¶³¾îÁö´Â ¼Ò¸®°¡ ³µ´Ù...", 2f);
        }
    }
}
