using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace OneTurretArmy
{
    [CreateAssetMenu(fileName = "PathDataBase", menuName = "PathDataBase")]
    public class PathDataBase : ScriptableObject
    {
        [Serializable]
        
        public struct PathData
        {
            public Image pathSprite;
            [ReadOnly]public int value;
        }
        
        public PathData[] pathData;
    }
}
