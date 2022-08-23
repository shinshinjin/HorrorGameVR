using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour , IInteraction
{
    public string ItemName { get; set; }

    public string _activeText;
    
    private void Awake()
    {
        _activeText = "æ∆¿Ã≈€ »πµÊ«œ±‚ (E)";
    }

    public void Interaction()
    {
        
        Debug.Assert(ItemName != null);
        if(ItemName == "11∞≠¿«Ω« ø≠ºË")
        {
            ItemManager.Instance.IsHave11ClassKey = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "Ω∫∏∂∆Æ∆˘")
        {
            ItemManager.Instance.IsHavePhone = true;
            gameObject.SetActive(false);
        }

        if(ItemName == "∆©≈‰∏ÆæÛ πÊπÆ ø≠ºË")
        {
            ItemManager.Instance.IsHaveTutorialKey = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "µÂ∂Û¿Ãπˆ")
        {
            ItemManager.Instance.IsHaveDriver = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "«ÿ∏”")
        {
            ItemManager.Instance.IsHaveHammer = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "≥Î∆Æ∫œ")
        {
            ItemManager.Instance.IsHaveNoteBook = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "√¢∞Ì ø≠ºË")
        {
            ItemManager.Instance.IsHaveRingKey = true;
            gameObject.SetActive(false);
        }

        if (ItemName == "101»£ ø≠ºË")
        {
            ItemManager.Instance.IsHave101Key = true;
            gameObject.SetActive(false);
        }

    }
}
