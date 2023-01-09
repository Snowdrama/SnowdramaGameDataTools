using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/Vector3Int Modifier")]
    public class Vector3IntGameDataModifier : GameDataModifier<Vector3Int>
    {
        public enum Vector3IntGameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public Vector3IntGameDataModifierType modifierType;
        public Vector3Int changeAmount;
    }
}
