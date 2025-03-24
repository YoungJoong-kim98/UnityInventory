using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private ItemSlot slotPrefab;
    [SerializeField] private Transform slotParent;


    [SerializeField] private int maxSlotCount = 100; // ÃÑ ½½·Ô ¼ö
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
        // ±âÁ¸ ½½·Ô Á¦°Å
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);
        slotList.Clear();

        // 100°³ ½½·Ô »ý¼º
        for (int i = 0; i < maxSlotCount; i++)
        {
            ItemSlot slot = Instantiate(slotPrefab, slotParent);

            if (i < inventoryItems.Count)
            {
                slot.SetSlot(inventoryItems[i]); // ½ÇÁ¦ ¾ÆÀÌÅÛ ¼³Á¤
            }
            else
            {
                slot.SetEmpty(); // ºó ½½·ÔÀ¸·Î ¼³Á¤
            }

            slotList.Add(slot);
        }

    }
}
