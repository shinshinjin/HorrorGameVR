using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR_Screen_Change : MonoBehaviour
{
    public CCTVInteraction CCTVInteraction;
    public Material CCTV;
    public MeshRenderer _render;


    //private void Awake()
    //{
    //    _render = GetComponent<MeshRenderer>();
    //}

    public void ScreenChange()
    {
        _render.material = CCTV;
    }
}
