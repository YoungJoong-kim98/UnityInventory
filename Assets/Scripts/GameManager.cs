using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<ItemData> dummyItems;
    public Character Player { get; private set; }

    //private List<InventoryItem> inventoryItems = new List<InventoryItem>();

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

        foreach (var itemData in dummyItems)
        {
            var item = new InventoryItem(itemData, 1); //아이템 생성자 데이터 추가 인벤토리용으로 바꿈
            Player.AddItem(item); // 플레이어인벤토리에 추가
        }
    }

    private void Start()
    {
        SetData();

        //  수정된 리스트 넘기기
        UIManager.Instance.UIInventory.InitInventoryUI(Player.Inventory);
    }

    public void SetData()
    {
        UIManager.Instance.UIMainMenu.SetData(Player);
        UIManager.Instance.UIStatus.SetData(Player);
    }
}
