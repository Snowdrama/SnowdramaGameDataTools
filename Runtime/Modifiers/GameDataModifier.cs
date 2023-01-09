using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Snowdrama.GameData
{
    public class GameDataModifier<T> : ScriptableObject
    {
        public GameDataKey<T> gameDataKey;
    }
}
