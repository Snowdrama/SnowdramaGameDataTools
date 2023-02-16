using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Snowdrama.GameData
{
    public enum GameDataModifierType
    {
        Change = 0,
        Set = 1,
    }
    public class GameDataModifier<T> : ScriptableObject
    {
        public GameDataKey<T> gameDataKey;
    }
}
