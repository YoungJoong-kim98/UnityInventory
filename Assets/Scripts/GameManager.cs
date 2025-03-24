using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<ItemData> dummyItems;
    public Character Player { get; private set; }
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

    }


    private void Start()
    {
        SetData();
        UIManager.Instance.UIInventory.InitInventoryUI(dummyItems);
    }

    public void SetData()
    {

        UIManager.Instance.UIMainMenu.SetData(Player);
        UIManager.Instance.UIStatus.SetData(Player);
    }
}
