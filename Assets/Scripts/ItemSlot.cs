using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI countText;

    private ItemData itemData;

    public void SetSlot(ItemData data)
    {
        itemData = data;

        iconImage.sprite = itemData.icon;
        iconImage.enabled = itemData.icon != null;

        countText.text = itemData.count > 0 ? itemData.count.ToString() : "";
    }

    public ItemData GetItem() => itemData;
}
