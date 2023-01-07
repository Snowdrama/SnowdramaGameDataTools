using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class GameDataObject : ScriptableObject
    {
        public GameData gameData;
        private void OnEnable()
        {
            if (gameData == null)
            {
                gameData = new GameData();
            }
            gameData.ClearAllData();
        }
        private void OnDisable()
        {
            if (gameData == null)
            {
                gameData = new GameData();
            }
            gameData.ClearAllData();
        }
    }
}