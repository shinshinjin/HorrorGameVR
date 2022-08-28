using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureEYEmove : MonoBehaviour
{
    public GameObject[] _picture;


    //哭率, 啊款单, 坷弗率
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _picture[0].gameObject.SetActive(true);
            _picture[1].gameObject.SetActive(false);
            _picture[2].gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _picture[0].gameObject.SetActive(false);
            _picture[1].gameObject.SetActive(true);
            _picture[2].gameObject.SetActive(false);
        }
    }
}
