using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/Vector2Int Modifier")]
    public class Vector2IntGameDataModifier : GameDataModifier<Vector2Int>
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
