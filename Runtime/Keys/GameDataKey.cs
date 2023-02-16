using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snowdrama.GameData
{
    public abstract class GameDataKey<T> : ScriptableObject
    {
        public Action onChange;
        [SerializeField] private string _keyName;
        public string KeyName
        {
            get
            {
                return _keyName;
            }
            set
            {
                _keyName = value;
            }
        }
        private void OnValidate()
        {
            if (string.IsNullOrEmpty(_keyName))
            {
                _keyName = this.name;
            }
        }
    }
}