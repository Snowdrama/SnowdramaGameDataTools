using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/int Modifier")]
    public class IntGameDataModifier : GameDataModifier<int>
    {
        public GameDataModifierType modifierType;
        public int changeAmount;
    }
}
