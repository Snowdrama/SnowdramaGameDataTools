using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/Vector3 Modifier")]
    public class Vector3GameDataModifier : GameDataModifier<Vector3>
    {
        public enum Vector3GameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public Vector3GameDataModifierType modifierType;
        public Vector3 changeAmount;
    }
}
