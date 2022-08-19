using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public string ItemName;
    public Sprite ItemImage;

    public Image _image;

    

    private void Update()
    {
        if(ItemImage != null && ItemName != null)
        {
            _image.sprite = ItemImage;
            Color color = _image.color;
            color.a = 1f;
            _image.color = color;
        }
    }
}
