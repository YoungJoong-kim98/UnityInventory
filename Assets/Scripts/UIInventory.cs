using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private ItemSlot slotPrefab;
    [SerializeField] private Transform slotParent;


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
        // ���� ���� ����
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);
        slotList.Clear();

        // 100�� ���� ����
        for (int i = 0; i < maxSlotCount; i++)
        {
            ItemSlot slot = Instantiate(slotPrefab, slotParent);

            if (i < inventoryItems.Count)
            {
                slot.SetSlot(inventoryItems[i]); // ���� ������ ����
            }
            else
            {
                slot.SetEmpty(); // �� �������� ����
            }

            slotList.Add(slot);
        }

    }
}
