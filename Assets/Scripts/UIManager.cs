using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private GameObject UIMainMenu;
    [SerializeField] private GameObject UIStatus;
    [SerializeField] private GameObject UIInventory;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void OpenMainMenu() //뒤로가기 버튼
    {
        UIMainMenu.SetActive(true);
        UIStatus.SetActive(false);
        UIInventory.SetActive(false);
    }

    public void OpenStatus()
    {
        UIMainMenu.SetActive(false);
        UIStatus.SetActive(true);
    }

    public void OpenInventory()
    {
        UIMainMenu.SetActive(false);
        UIInventory.SetActive(true);
    }

}
