using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class Vector2IntGameDataModifier : GameDataModifier
    {
        public enum Vector2IntGameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public Vector2IntGameDataModifierType modifierType;
        public Vector2Int changeAmount;
    }
}
