using UnityEngine;

[CreateAssetMenu(fileName = "CellReference", menuName = "ScriptableObjects/CellReference", order = 1)]
public class CellReference : ScriptableObject
{
    [System.Serializable]
    public struct GridCell
    {
        public Vector2Int position;
        public GameObject cellObject;

        public GridCell(Vector2Int pos, GameObject obj)
        {
            position = pos;
            cellObject = obj;
        }
    }
    
}
