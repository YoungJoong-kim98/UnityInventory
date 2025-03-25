using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private ItemSlot slotPrefab;
    [SerializeField] private Transform slotParent;
    [SerializeField] private TextMeshProUGUI InventoryCount;

    [SerializeField] private int maxSlotCount = 100; // �� ���� ��
    private List<ItemSlot> slotList = new List<ItemSlot>();

    private void Start()
    {
        backButton.onClick.AddListener(() =>
        {
            UIManager.Instance.UIMainMenu.OpenMainMenu();
        });
    }

    public void InitInventoryUI(List<InventoryItem> inventoryItems)
    {
        // ó���� 100�� ������ ��
        if (slotList.Count == 0)
        {
            for (int i = 0; i < maxSlotCount; i++)
            {
                ItemSlot slot = Instantiate(slotPrefab, slotParent);
                slotList.Add(slot);
            }
        }

        for (int i = 0; i < slotList.Count; i++)
        {
            if (i < inventoryItems.Count)
            {
                slotList[i].SetSlot(inventoryItems[i]); //���� ������ ����
            }
            else
            {
                slotList[i].SetEmpty(); // �󽽷�
            }
        }
        InventoryCount.text = $"Inventory <color=#FF0000>{inventoryItems.Count}</color> / {maxSlotCount}";

    }

    public void OnClickItemslot(ItemSlot targetslot,InventoryItem targetItem)
    {
        if (targetItem == null) return;

        if (targetItem.isEquipped)
        {
            GameManager.Instance.Player.UnEquip(targetItem);
        }
        else
        {
            GameManager.Instance.Player.Equip(targetItem);
        }

        // ���� UI ����
        targetslot.SetSlot(targetItem);

        // ���� UI�� ����
        UIManager.Instance.UIStatus.SetData(GameManager.Instance.Player);
    }

}
