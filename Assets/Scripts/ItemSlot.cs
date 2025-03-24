using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Outline outline; //  Outline 연결

    private InventoryItem inventoryItem;

    public void SetSlot(InventoryItem invItem)
    {
        inventoryItem = invItem;

        iconImage.sprite = invItem.itemData.icon;
        countText.text = invItem.count > 1 ? invItem.count.ToString() : "";

        // 장착 상태에 따라 테두리 강조
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
}
