using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GYLightOff : MonoBehaviour
{
    private void Update()
    {
        if(ItemManager.Instance.IsHaveNoteBook)
        {
            gameObject.SetActive(false);
        }
    }
}
