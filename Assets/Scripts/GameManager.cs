using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<ItemData> dummyItems;
    public Character Player { get; private set; }

    private List<InventoryItem> inventoryItems = new List<InventoryItem>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Player = new Character("YoungJoong", 1, 10, 5, 0, 100, 20000, 100, 25);

        //  여기서 ItemData 리스트를 InventoryItem 리스트로 변환
        foreach (var itemData in dummyItems)
        {
            inventoryItems.Add(new InventoryItem(itemData, 1));
        }
    }

    private void Start()
    {
        SetData();

        //  수정된 리스트 넘기기
        UIManager.Instance.UIInventory.InitInventoryUI(inventoryItems);
    }

    public void SetData()
    {
        UIManager.Instance.UIMainMenu.SetData(Player);
        UIManager.Instance.UIStatus.SetData(Player);
    }
}
