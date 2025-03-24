using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button BackButton;

    private void Start()
    {
        BackButton.onClick.AddListener(() => UIManager.Instance.UIMainMenu.OpenMainMenu());
    }
}
