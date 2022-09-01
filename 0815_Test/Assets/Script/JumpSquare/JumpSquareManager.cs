using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSquareManager : MonoBehaviour
{
    public GameObject _JumpSquare;
    private float realTime = 1f;

    private void OnTriggerStay(Collider other)
    {
        realTime += Time.deltaTime;
        if(other.tag == "Player")
        {
            StartCoroutine(LightOn());

            if(realTime > 3f)
            {
                StopCoroutine(LightOn());
                Destroy(gameObject, 3f);
            }
        }
    }

    IEnumerator LightOn()
    {
       while(true)
        {
            _JumpSquare.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            _JumpSquare.SetActive(false);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
