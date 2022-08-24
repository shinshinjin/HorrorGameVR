using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    [SerializeField]
    Image _fadeinImage;

    public Image image;
    private float elapsedTime = 0.005f;
    private float Alpha_Origin;


    public void Start()
    {
        StartCoroutine(FadeOutCoroutine());
    }

    public void FadeOut()
    {
        StartCoroutine(FadeInCoroutine());
    }

    IEnumerator FadeOutCoroutine()
    {
        Alpha_Origin = 1;

        while (Alpha_Origin > 0)
        {
            Alpha_Origin -= elapsedTime;
            yield return new WaitForSeconds(elapsedTime);
            image.color = new Color(0, 0, 0, Alpha_Origin);

            if (Alpha_Origin < 0.001)
            {
                _fadeinImage.gameObject.SetActive(false);
            }
        }
    }

    IEnumerator FadeInCoroutine()
    {
        Alpha_Origin = 0;

        while (Alpha_Origin < 1)
        {
            Alpha_Origin += elapsedTime;
            yield return new WaitForSeconds(elapsedTime);
            image.color = new Color(0, 0, 0, Alpha_Origin);
        }
    }
}
