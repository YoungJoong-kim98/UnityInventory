using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button BackButton;

    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI criticalText;
    private void Start()
    {
        BackButton.onClick.AddListener(() => UIManager.Instance.UIMainMenu.OpenMainMenu());
    }

    public void SetData(Character player) // 캐릭터 상태 설정
    {
        attackText.text = $"공격력\n{player.AttackPower.ToString()}";
        defenseText.text = $"방어력\n{player.DefensePower.ToString()}";
        healthText.text = $"체력\n{player.Health.ToString()}";
        criticalText.text = $"치명타\n{player.Critical.ToString()}";
    }
}
