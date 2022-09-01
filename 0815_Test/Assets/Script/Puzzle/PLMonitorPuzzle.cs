using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLMonitorPuzzle : MonoBehaviour
{
    public GameObject Class12Key;

    public PLClassHiddenEvent HiddenEvent;
    public AudioClip DropKey;

    [SerializeField]
    private MonitorInteraction[] Monitor;

    private int[] _correctOnMonitorNumber = new int[18] { 0, 4, 9, 12, 14, 15, 13, 16, 17, 18, 19, 20, 24, 26, 27, 21, 25, 28 };
    private int[] _correctOffMonitorNumber = new int[14] { 1, 2, 3, 6, 7, 5, 8, 11, 10, 22, 23, 30, 31, 29 };

    private int[] _hiddenOnNumber = new int[14] { 0, 4, 9, 12, 13, 14, 15, 16, 20, 25, 28, 29, 30, 31 };
    private int[] _hiddenOffNumber = new int[18] { 1, 2, 3, 5, 6, 7, 8, 10, 11, 17, 18, 19, 21, 22, 23, 24, 26, 27 };

    [SerializeField]
    private bool _PLClassPuzzleMonitorOnCorrect;
    [SerializeField]
    private bool _PLClassPuzzleMonitorOffCorrect;
    [SerializeField]
    private bool _PLClassHiddenPuzzleMonitorOnCorrect;
    [SerializeField]
    private bool _PLClassHiddenPuzzleMonitorOffCorrect;

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

        if(_PLClassPuzzleMonitorOnCorrect && _PLClassPuzzleMonitorOffCorrect && GameManager.Instance.IsPLClassPuzzleOver == false)
        {
            Debug.Log("퍼즐 잘 작동됨");
            GameManager.Instance.PlaySoundFromPlayer(DropKey);
            Class12Key.SetActive(true);
            UIManager.Instance.DrawAndEraseDialogueTextForSeconds("앞에서 무언가 떨어지는 소리가 났다...", 2f);
            GameManager.Instance.IsPLClassPuzzleOver = true;
        }

        for (int i = 0; i < _hiddenOnNumber.Length; i++)
        {
            if (Monitor[_hiddenOnNumber[i]]._isScreenOn)
            {
                _PLClassHiddenPuzzleMonitorOnCorrect = true;
            }
            else
            {
                _PLClassHiddenPuzzleMonitorOnCorrect = false;
                break;
            }
        }

        for (int i = 0; i < _hiddenOffNumber.Length; i++)
        {
            if (Monitor[_hiddenOffNumber[i]]._isScreenOn == false)
            {
                _PLClassHiddenPuzzleMonitorOffCorrect = true;
            }
            else
            {
                _PLClassHiddenPuzzleMonitorOffCorrect = false;
                break;
            }
        }

        if (_PLClassHiddenPuzzleMonitorOnCorrect && _PLClassHiddenPuzzleMonitorOffCorrect && GameManager.Instance.IsPLClassHiddenPuzzleOver == false)
        {
            Debug.Log("히든퍼즐 잘 작동됨");
            GameManager.Instance.IsPLClassHiddenPuzzleOver = true;
            HiddenEvent.HiddenEventStart();
            //GameManager.Instance.PlaySoundFromPlayer(DropKey);
            //Class12Key.SetActive(true);
            //UIManager.Instance.DrawAndEraseDialogueTextForSeconds("앞에서 무언가 떨어지는 소리가 났다...", 2f);
            //GameManager.Instance.IsPLClassPuzzleOver = true;
        }
    }
}
