using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager _instance;

    #region 아이템리스트
    public bool IsHave11ClassKey { get; set; }
    public bool Already11ClassHaveKey { get; set; }
    public bool IsHavePhone { get; set; }
    public bool AlreadyHavePhone { get; set; }
    public bool IsHaveTutorialKey { get; set; }
    public bool AlreadyHaveTutorialKey { get; set; }
    public bool IsHaveDriver { get; set; }
    public bool AlreadyHaveDriver { get; set; }
    public bool IsHaveHammer { get; set; }
    public bool AlreadyHaveHammer { get; set; }
    public bool IsHaveNoteBook { get; set; }
    public bool AlreadyHaveNoteBook { get; set; }
    public bool IsHaveRingKey { get; set; }
    public bool AlreadyHaveRingKey { get; set; }
    public bool IsHave101Key { get; set; }
    public bool AlreadyHave101Key { get; set; }
    public bool IsHaveLighter { get; set; }
    public bool AlreadyHaveLighter { get; set; }
    public bool IsHaveScreenRemote { get; set; }
    public bool AlreadyHaveScreenRemote { get; set; }
    public bool IsHaveCCTV { get; set; }
    public bool AlreadyHaveCCTV { get; set; }
    public bool IsHave12ClassStorageKey { get; set; }
    public bool AlreadyHave12ClassStorageKey { get; set; }
    public bool IsHaveLightSwitch { get; set; }
    public bool AlreadyHaveLightSwitch { get; set; }
    public bool IsHaveBrain { get; set; }
    public bool AlreadyHaveBrain { get; set; }
    public bool IsHaveScreenCofferKey { get; set; }
    public bool AlreadyHaveScreenCofferKey { get; set; }
    public bool IsHaveTherapyRoomKey { get; set; }
    public bool AlreadyHaveTherapyRoomKey { get; set; }
    public bool IsHaveHospitalKey { get; set; }
    public bool AlreadyHaveHospitalKey { get; set; }
    public bool IsHaveNamePlate { get; set; }
    public bool AlreadyHaveNamePlate { get; set; }
    public bool IsHaveMainKey { get; set; }
    public bool AlreadyHaveMainKey { get; set; }
    #endregion

    public ItemData[] itemDatas;

    public bool[] isSelected;

    public string CurrentItemName;
    public Slot CurrentSlot;
    public Sprite DefaultSlotImage;
    public Sprite DefaultItemImage;

    public static ItemManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ItemManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    /// <summary>
    /// 선택 된 인벤토리 슬롯을 전부 해제하는 함수
    /// </summary>
    public void ResetSelect()
    {
        for(int i = 0; i < isSelected.Length; i++)
        {
            isSelected[i] = false;
        }
    }

    public void UsedItem()
    {
        CurrentSlot.ItemName = "";
        CurrentSlot.ItemImage = DefaultSlotImage;
        CurrentSlot._isItemIn = false;
        UIManager.Instance.SelectedItemTextWithInventory.text = "";
    }
}
