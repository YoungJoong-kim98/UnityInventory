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

    public void SetData(Character player) // ĳ���� ���� ����
    {
        attackText.text = $"���ݷ�\n{player.AttackPower.ToString()}";
        defenseText.text = $"����\n{player.DefensePower.ToString()}";
        healthText.text = $"ü��\n{player.Health.ToString()}";
        criticalText.text = $"ġ��Ÿ\n{player.Critical.ToString()}";
    }
}
