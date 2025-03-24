[System.Serializable]
public class InventoryItem
{
    public ItemData itemData; // ���� ����
    public int count;         // ���� ����
    public bool isEquipped;   // ���� ����

    public InventoryItem(ItemData data, int count = 1)
    {
        itemData = data;
        this.count = count;
        isEquipped = false;
    }
}
