using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GYMainDoorChanger : MonoBehaviour
{
    public GameObject[] _door;

    private void Update()
    {
        if(ItemManager.Instance.IsHaveNoteBook)
        {
            _door[0].SetActive(false);
            _door[1].SetActive(true);
        }
    }
}
