using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/string Modifier")]
    public class StringGameDataModifier : GameDataModifier<string>
    {
        public string newValue;
    }
}
