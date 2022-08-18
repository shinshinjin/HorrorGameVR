using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{
    [SerializeField]
    public float range; // ���� ������ �ִ� �Ÿ�

    private bool pickupActivated = false; // ���� ������ �� true.

    private RaycastHit hitInfo; // �浹ü ���� ����.

    [SerializeField]
    private LayerMask layerMask; // ������ ���̾�� �����ϵ��� ���̾� ����ũ ����

    [SerializeField]
    private Text actionText; // �ʿ��� ������Ʈ

    
    void Update()
    {
        TryAction();
    }

    private void TryAction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckItem();
            CanPickUp(); // �����ϸ� �ݴ� ��.
        }
    }

    private void CanPickUp()
    {
        if(pickupActivated)
        {
            if(hitInfo.transform != null) // ���� ����
            {
                Debug.Log(hitInfo.transform.GetComponent<ItemPickUp>().item.itemName + " ȹ���߽��ϴ�. ");
                Destroy(hitInfo.transform.gameObject); // ȹ���� ������ �ı� (������Ʈ Ǯ�� ����?)
                InfoDisappear();
            }
        }
    }

    private void CheckItem()
    {
        //transform.TransformDirection(Vector3.forward) : Vector3�� ������ ���� �������� ��ȯ �����ִ� ��. (Vector3.forward)�� ����� ��ǥ. �÷��̾�: ���û� ��ǥ�̹Ƿ� �� �������� �ٲ� �ִ� ��.
        // out hitInfo : �浹ü�� ������ �޾Ƽ� ���� ��Ű�� ��
        // layerMask�� ����Ͽ� ���� �浹�ߴٰ� True �� �ٲ��ָ� �ȵǹǷ� �����۸� �浹���� ��츸 True�� �ٲ���� �Ѵ�.
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, range, layerMask))
        { 
            if (hitInfo.transform.tag == "Item")
            {
                ItemInfoAppear();
            }
            // �� ��� ������ ������ ����.

            // ���� �±׸� �ѹ� �� ���ϴ� ���� : �ٸ� �������� ��Ұ� �ֱ� ����. ex) ���� �ٶ� ��, ����� ���� �� �� �ֵ���.
        }
        else
        {
            InfoDisappear();
        }
    }

    private void ItemInfoAppear()
    {
        pickupActivated = true; // ȹ�� �� �� ����
        actionText.gameObject.SetActive(true); // ȹ�� �����ϴٰ� ����.
        actionText.text = hitInfo.transform.GetComponent<ItemPickUp>().item.itemName + " ȹ�� " + "<color=yellow>" + "(E)" + "</color>";
    }

    private void InfoDisappear()
    {
        pickupActivated = false; // ȹ�� �Ұ�
        actionText.gameObject.SetActive(false); // ������ ȹ�� ������ ������� ����.
    }

}
