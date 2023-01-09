using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/int Modifier")]
    public class IntGameDataModifier : GameDataModifier<int>
    {
        public enum IntGameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public IntGameDataModifierType modifierType;
        public int changeAmount;
    }
}
