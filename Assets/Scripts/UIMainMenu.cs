using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject uiMainMenuObj;
    [SerializeField] private GameObject uiStatusObj;
    [SerializeField] private GameObject uiInventoryObj;

    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;


    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private TextMeshProUGUI Exp;

    private void Start()
    {
        statusButton.onClick.AddListener(() => OpenStatus());
        inventoryButton.onClick.AddListener(() => OpenInventory());
    }
    public void OpenMainMenu() //메인화면
    {
        uiMainMenuObj.SetActive(true);
        uiStatusObj.SetActive(false);
        uiInventoryObj.SetActive(false);
    }

    public void OpenStatus() //캐릭터 상태화면
    {
        uiMainMenuObj.SetActive(false);
        uiStatusObj.SetActive(true);
        uiInventoryObj.SetActive(false);
    }

    public void OpenInventory() // 인벤토리 화면
    {
        uiMainMenuObj.SetActive(false);
        uiStatusObj.SetActive(false);
        uiInventoryObj.SetActive(true);
    }

    public void SetData(Character player) //캐릭터 데이터 설정
    {
        nameText.text = player.Name;
        levelText.text = $"Lv {player.Lv}";
        goldText.text = $"{player.Gold}";
        Exp.text = $"{player.CurrentEXP} / {player.MaxExp}";
    }
}
