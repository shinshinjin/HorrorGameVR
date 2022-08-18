using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item; // 획득한 아이템
    public int itemCount; // 획득한 아이템의 개수
    public Image itemImage; // 아이템의 이미지

    // 필요한 컴포넌트
    [SerializeField]
    public Text text_Count;
    [SerializeField]
    private GameObject go_CountImage; //??

    // 이미지의 투명도 조절
    private void SetColor(float _alpha) // 아이템 획득 했을 때와 안했을 때의 투명도
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color; // 실제 아이템 이미지의 컬러를 조정.
    }

    // 아이템 획득
    public void AddItem(Item _item, int _count = 1)
    {
        item = _item;
        itemCount = _count;
        itemImage.sprite = item.itemImage;


        if (item.itemType != Item.ItemType.Used)
        {
            go_CountImage.SetActive(true);
            text_Count.text = itemCount.ToString(); // string 으로 형변환.
        }

        // 만약에 사용 아이템이다, 면 굳이 파란색 동그라미 활성화 필요 없음
        else
        {
            text_Count.text = "0";
            go_CountImage?.SetActive(false);
        }

        SetColor(1);
    }

    // 아이템 개수 조정
    public void SetSlotCount(int _count)
    {
        itemCount += _count; // 아이템 슬롯 카운트 갯수
        text_Count.text = itemCount.ToString(); 

        // 0과 같거나 작아졌다면..
        if(itemCount <= 0)
        {
            ClearSlot();
        }
    }

    // 슬롯 초기화
    private void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0);

        text_Count.text ="0";
        go_CountImage.SetActive(false);
    }


}
