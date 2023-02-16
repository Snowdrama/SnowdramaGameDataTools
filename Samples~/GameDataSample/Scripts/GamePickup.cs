using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snowdrama.GameData;

public class GamePickup : MonoBehaviour
{

    public IntGameDataModifier ItemToAdd;
    public void PickedUp()
    {
        Destroy(this.gameObject);
    }
}
