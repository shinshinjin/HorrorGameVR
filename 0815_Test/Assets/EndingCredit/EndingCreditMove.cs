using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCreditMove : MonoBehaviour
{
    private float _elapsedTime = 0.1f;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime > 1f)
        {
            StartCoroutine(Ending());
            _elapsedTime = 0;
        }
    }

    IEnumerator Ending()
    {
        while (true)
        {
            {
                transform.Translate(0, -0.1f, 0);
                yield return null;
            }
        }
    }
}
