using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour , IInteraction
{
    public string ItemName { get; set; }

    private AudioSource _getItemSound;

    public string _activeText;
    
    private void Awake()
    {
        _getItemSound = GetComponent<AudioSource>();
        _activeText = "æ∆¿Ã≈€ »πµÊ«œ±‚ (E)";
    }

    public void Interaction()
    {
        _getItemSound.Play();

        CheckItem();

        Invoke("BreakItem", 0.2f);
    }

    private void CheckItem()
    {
        Debug.Assert(ItemName != null);
        if (ItemName == "11∞≠¿«Ω« ø≠ºË")
        {
            ItemManager.Instance.IsHave11ClassKey = true;
        }

        if (ItemName == "Ω∫∏∂∆Æ∆˘")
        {
            ItemManager.Instance.IsHavePhone = true;
        }

        if (ItemName == "∆©≈‰∏ÆæÛ πÊπÆ ø≠ºË")
        {
            ItemManager.Instance.IsHaveTutorialKey = true;
        }

        if (ItemName == "µÂ∂Û¿Ãπˆ")
        {
            ItemManager.Instance.IsHaveDriver = true;
        }

        if (ItemName == "«ÿ∏”")
        {
            ItemManager.Instance.IsHaveHammer = true;
        }

        if (ItemName == "≥Î∆Æ∫œ")
        {
            ItemManager.Instance.IsHaveNoteBook = true;
        }

        if (ItemName == "√¢∞Ì ø≠ºË")
        {
            ItemManager.Instance.IsHaveRingKey = true;
        }

        if (ItemName == "101»£ ø≠ºË")
        {
            ItemManager.Instance.IsHave101Key = true;
        }
    }
    private void BreakItem()
    {
        gameObject.SetActive(false);
    }
}
