using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLMonitorPuzzle : MonoBehaviour
{
    [SerializeField]
    private MonitorInteraction[] Monitor;

    private int[] _correctOnMonitorNumber = new int[17] { 0, 4, 9, 12, 14, 15, 13, 16, 17, 18, 19, 20, 22, 23, 21, 25, 28 };
    private int[] _correctOffMonitorNumber = new int[15] { 1, 2, 3, 6, 7, 5, 8, 11, 10, 24, 27, 26, 30, 31, 29 };

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
        
        for (int i = 0; i < 17; i++) 
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

        for (int i = 0; i < 15; i++)
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
        }
    }
}
