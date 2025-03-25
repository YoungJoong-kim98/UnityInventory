using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Outline outline; //  Outline ����

    private InventoryItem inventoryItem;

    public void SetSlot(InventoryItem invItem)
    {
        inventoryItem = invItem;

        iconImage.sprite = invItem.itemData.icon;
        countText.text = invItem.count > 1 ? invItem.count.ToString():
                         invItem.isEquipped ? "E"  :
                         "";

        // ���� �׵θ�
        outline.enabled = invItem.isEquipped;
    }

    public void SetEmpty()
    {
        inventoryItem = null;
        iconImage.sprite = null;
        iconImage.enabled = false;
        countText.text = "";
        outline.enabled = false;
    }

    public void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClickSlot);
    }

    private void OnClickSlot()
    {
        if (inventoryItem == null) return;

        // ���� ���¿� ���� ���
        if (inventoryItem.isEquipped)
        {
            GameManager.Instance.Player.UnEquip(inventoryItem);
        }
        else
        {
            GameManager.Instance.Player.Equip(inventoryItem);
        }

        // ���� UI ����
        SetSlot(inventoryItem);

        // ���� UI�� ����
        UIManager.Instance.UIStatus.SetData(GameManager.Instance.Player);
    }
}
