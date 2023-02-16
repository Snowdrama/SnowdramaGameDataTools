using Snowdrama.GameData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameDataObject gameDataObject;
    public BoolGameDataKey aliveGameKey;
    public IntGameDataKey healthKey;
    public IntGameDataKey maxHealthKey;

    public int startingHealth = 50;
    public int startingMaxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        gameDataObject.gameData.SetFlagBool(aliveGameKey, true);
        gameDataObject.gameData.SetFlagInt(healthKey, startingHealth);
        gameDataObject.gameData.SetFlagInt(maxHealthKey, startingMaxHealth);
        healthKey.onChange += OnHealthChanged;
    }

    public void OnHealthChanged()
    {
        var alive = gameDataObject.gameData.GetFlagBool(aliveGameKey, true);
        var health = gameDataObject.gameData.GetFlagInt(healthKey, startingHealth);
        var maxHealth = gameDataObject.gameData.GetFlagInt(maxHealthKey, startingMaxHealth);
        //we died
        if (alive && health <= 0)
        {
            gameDataObject.gameData.SetFlagInt(healthKey, 0);
            gameDataObject.gameData.SetFlagBool(aliveGameKey, false);
        }

        if(health > maxHealth)
        {
            Debug.LogErrorFormat("Health Is {0} which is Over Max of {1} Setting Health to max", health, maxHealth);
            gameDataObject.gameData.SetFlagInt(healthKey, maxHealth);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
