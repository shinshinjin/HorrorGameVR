using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    private float moveSpeed = 0.01f;
    private float _elapsedTime = 0.03f;
    private bool isDoctorSeeThat = false;

    void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (isDoctorSeeThat == false)
        {
            if (_elapsedTime > 2f)
            {
                StartCoroutine(HeadingMovePlus());
                _elapsedTime = 0f;
                isDoctorSeeThat = true;
            }
        }

        else
        {
            if (_elapsedTime > 2f)
            {
                StopCoroutine(HeadingMovePlus());
                StartCoroutine(HeadingMoveMinus());
                _elapsedTime = 0f;
                isDoctorSeeThat = false;
            }
        }

    }

    IEnumerator HeadingMovePlus()
    {
        while (true)
        {
            transform.Translate(0, moveSpeed, 0);
            yield return null;
        }
    }

    IEnumerator HeadingMoveMinus()
    {
        while (true)
        {
            transform.Translate(0, -0.04f, 0);
            yield return null;
        }
    }



}

