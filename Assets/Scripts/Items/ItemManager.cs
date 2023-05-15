using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public SOInt coins;
    public SOInt exp;
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextExp;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        exp.value = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        exp.value += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        //uiTextCoins.text = coins.ToString();
        //UIInGameManager.UpdateTextCoins(coins.value.ToString());
    }
}
