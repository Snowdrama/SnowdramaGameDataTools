using Snowdrama.GameData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public GameDataObject gameDataObject;

    [Header("Gold")]
    public IntGameDataKey goldKey;
    public TMPro.TMP_Text goldUIText;
    string goldString = "Gold: {0}";

    [Header("Ammo")]
    public IntGameDataKey ammoKey;
    public TMPro.TMP_Text ammoUIText;
    string ammoString = "Ammo: {0}";

    [Header("Health")]
    public IntGameDataKey healthKey;
    public IntGameDataKey maxHealthKey;
    public TMPro.TMP_Text healthUIText;
    private int health;
    private int maxHealth;
    string healthString = "{0}/{1}";

    private void Start()
    {
        goldKey.onChange += GoldAdded;
        ammoKey.onChange += AmmoAdded;
        healthKey.onChange += HealthChanged;
        maxHealthKey.onChange += MaxHealthChanged;

        goldUIText.text = string.Format(goldString, gameDataObject.gameData.GetFlagInt(goldKey, 0));
        goldUIText.text = string.Format(ammoString, gameDataObject.gameData.GetFlagInt(ammoKey, 0));
        health = gameDataObject.gameData.GetFlagInt(healthKey, 0);
        maxHealth = gameDataObject.gameData.GetFlagInt(maxHealthKey, 0);
        healthUIText.text = string.Format(healthString, health, maxHealth);
    }

    private void GoldAdded()
    {
        var gold = gameDataObject.gameData.GetFlagInt(goldKey, 0);
        goldUIText.text = string.Format(goldString, gold);
    }
    private void AmmoAdded()
    {
        var ammmo = gameDataObject.gameData.GetFlagInt(ammoKey, 0);
        goldUIText.text = string.Format(ammoString, ammmo);
    }
    private void HealthChanged()
    {
        health = gameDataObject.gameData.GetFlagInt(healthKey, 0);
        maxHealth = gameDataObject.gameData.GetFlagInt(maxHealthKey, 0);
        UpdateHealthDisplay();
    }
    private void MaxHealthChanged()
    {
        health = gameDataObject.gameData.GetFlagInt(healthKey, 0);
        maxHealth = gameDataObject.gameData.GetFlagInt(maxHealthKey, 0);
        UpdateHealthDisplay();
    }
    private void UpdateHealthDisplay()
    {
        healthUIText.text = string.Format(healthString, health, maxHealth);
    }

}
