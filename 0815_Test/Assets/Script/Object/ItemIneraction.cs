using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIneraction : MonoBehaviour, IInteraction
{
    public Transform _player;

    private bool _isGet;
    private bool _isMoveDrawer;
    private float _elapsedTime;
    private float _canInteractionDistance = 6f;

    [SerializeField]
    private Inventory theInventory;

    private void Interaction()
    {
        if (_isGet)
        {
            Get();
        }
        else
        {
            _isGet = false;
        }
    }

    private void OnMouseOver()
    {
        if (Vector3.Distance(transform.position, _player.position) < _canInteractionDistance)
        {
            UIManager.Instance.InteractDrawText("¿­¼è È¹µæ" + "<color=yellow>" + "(E)" + "</color>", true);
        }
        else
        {
            UIManager.Instance.InteractDrawText("¿­¼è È¹µæ" + "<color=yellow>" + "(E)" + "</color>", false);
        }


        if (Input.GetKeyDown(KeyCode.E) && GetDistanceFromInteractObject() < _canInteractionDistance && _isMoveDrawer == false)
        {
            _isGet = true;
            Interaction();
            Debug.Log("¿­¼è¸¦ È¹µæ");

            //¿ÀºêÁ§Æ® ÀÌ¸§ ¾îÄÉ Ã£´©? ¤»¤» 
            //theInventory.AcquireItem();

            UIManager.Instance.gameObject.SetActive(false);
            UIManager.Instance.InteractDrawText("¿­¼è È¹µæ" + "<color=yellow>" + "(E)" + "</color>", false);
            //Get();
        }
    }

    private void OnMouseExit()
    {
        UIManager.Instance.InteractDrawText("¿­¼è È¹µæ" + "<color=yellow>" + "(E)" + "</color>", false);
    }

    private void Get()
    {
        Destroy(gameObject);
    }

    private float GetDistanceFromInteractObject()
    {
        return Vector3.Distance(transform.position, _player.position);
    }
}
