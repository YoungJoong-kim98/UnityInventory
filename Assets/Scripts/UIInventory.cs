using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private ItemSlot slotPrefab;
    [SerializeField] private Transform slotParent;

    private List<ItemSlot> slotList = new List<ItemSlot>();

    private void Start()
    {
        backButton.onClick.AddListener(() =>
        {
            UIManager.Instance.UIMainMenu.OpenMainMenu();
        });
    }

    public void InitInventoryUI(List<ItemData> items)
    {
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);

        slotList.Clear();

        foreach (var item in items)
        {
            ItemSlot slot = Instantiate(slotPrefab, slotParent);
            slot.SetSlot(item);
            slotList.Add(slot);
        }
    }
}
