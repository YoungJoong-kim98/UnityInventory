[System.Serializable]
public class InventoryItem
{
    public ItemData itemData; // 고정 정보
    public int count;         // 동적 정보
    public bool isEquipped;   // 장착 여부

    public InventoryItem(ItemData data, int count = 1)
    {
        itemData = data;
        this.count = count;
        isEquipped = false;
    }
}
