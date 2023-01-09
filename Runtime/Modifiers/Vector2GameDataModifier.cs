using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/Vector2 Modifier")]
    public class Vector2GameDataModifier : GameDataModifier<Vector2>
    {
        public enum Vector2GameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public Vector2GameDataModifierType modifierType;
        public Vector2 changeAmount;
    }
}
