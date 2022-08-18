using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{
    [SerializeField]
    public float range; // 습득 가능한 최대 거리

    private bool pickupActivated = false; // 습득 가능할 시 true.

    private RaycastHit hitInfo; // 충돌체 정보 저장.

    [SerializeField]
    private LayerMask layerMask; // 아이템 레이어에만 반응하도록 레이어 마스크 설정

    [SerializeField]
    private Text actionText; // 필요한 컴포넌트

    
    void Update()
    {
        TryAction();
    }

    private void TryAction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckItem();
            CanPickUp(); // 가능하면 줍는 것.
        }
    }

    private void CanPickUp()
    {
        if(pickupActivated)
        {
            if(hitInfo.transform != null) // 오류 방지
            {
                Debug.Log(hitInfo.transform.GetComponent<ItemPickUp>().item.itemName + " 획득했습니다. ");
                Destroy(hitInfo.transform.gameObject); // 획득한 아이템 파괴 (오브젝트 풀링 가능?)
                InfoDisappear();
            }
        }
    }

    private void CheckItem()
    {
        //transform.TransformDirection(Vector3.forward) : Vector3의 방향을 로컬 방향으로 전환 시켜주는 것. (Vector3.forward)는 월드상 좌표. 플레이어: 로컬상 좌표이므로 그 방향으로 바꿔 주는 것.
        // out hitInfo : 충돌체에 정보를 받아서 저장 시키는 것
        // layerMask를 사용하여 모든걸 충돌했다고 True 로 바꿔주면 안되므로 아이템만 충돌했을 경우만 True로 바꿔줘야 한다.
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, range, layerMask))
        { 
            if (hitInfo.transform.tag == "Item")
            {
                ItemInfoAppear();
            }
            // 이 경우 아이템 정보를 띄운다.

            // 굳이 태그를 한번 더 비교하는 이유 : 다른 여러가지 요소가 있기 때문. ex) 문을 바라볼 때, 열쇠로 문을 열 수 있도록.
        }
        else
        {
            InfoDisappear();
        }
    }

    private void ItemInfoAppear()
    {
        pickupActivated = true; // 획득 할 수 있음
        actionText.gameObject.SetActive(true); // 획득 가능하다고 켜짐.
        actionText.text = hitInfo.transform.GetComponent<ItemPickUp>().item.itemName + " 획득 " + "<color=yellow>" + "(E)" + "</color>";
    }

    private void InfoDisappear()
    {
        pickupActivated = false; // 획득 불가
        actionText.gameObject.SetActive(false); // 아이템 획득 했으니 사라지게 만듦.
    }

}
