using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class GameDataKey : ScriptableObject
    {
        //settable in the editor but then not modifiable
        [SerializeField] private string _keyName;
        public string KeyName
        {
            get
            {
                return _keyName;
            }
        }
    }
}