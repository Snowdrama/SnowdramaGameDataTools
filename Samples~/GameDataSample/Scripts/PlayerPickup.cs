using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snowdrama.GameData;
public class PlayerPickup : MonoBehaviour
{
    public GameDataObject gameDataObject;
    private void OnTriggerEnter(Collider other)
    {
        var pickup = other.gameObject.GetComponent<GamePickup>();
        if (pickup)
        {
            Debug.LogFormat("Adding {0} to {1}", pickup.ItemToAdd.changeAmount, pickup.ItemToAdd.gameDataKey.KeyName);
            gameDataObject.gameData.ApplyModifier(pickup.ItemToAdd);
            pickup.PickedUp();
        }
    }
}
