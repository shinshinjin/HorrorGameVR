using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items/ItemData", menuName = "ScriptableObject/ItemData")]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public Sprite ItemImage;
}
