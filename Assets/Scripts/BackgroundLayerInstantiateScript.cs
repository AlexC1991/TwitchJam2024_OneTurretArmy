using System.Collections;
using UnityEngine;

namespace OneTurretArmy
{
    public class BackgroundLayerInstantiateScript : MonoBehaviour
    {
        [Range(-100, 100)] [SerializeField] private float gridPositionX;
        [Range(-100, 100)] [SerializeField] private float gridPositionY;
        [Range(-1, 3)] [SerializeField] private float cellSize;
        [Range(-100, 100)] [SerializeField] private int gridXSize;
        [Range(-100, 100)] [SerializeField] private int gridYSize;
        [Range(-100, 100)] [SerializeField] private int cellExpandX;
        [Range(-100, 100)] [SerializeField] private int cellExpandY;
        [SerializeField] private Canvas imageParent;
        [Range(0.01f, 0.1f)] [SerializeField] private float delay;
        [Header("Tile Prefab")]
        [SerializeField] private Object gridCellPrefab;
        [SerializeField] private PathGenerationLayerScript pG;
        private int [,] grid;
        private Vector3 gridCenter;
        public GameObject spawnTile;
        private Vector3 cellCenter;
        private Coroutine startingGrid;
        private int maxValue;
        private int currentValue;
        
        private void Start()
        {
            startingGrid = StartCoroutine(InitializeGrid());
        }

        private IEnumerator InitializeGrid()
        {
            UpdateGrid();
            
            int totalTiles = (gridXSize - cellExpandX) * (gridYSize - cellExpandY);
            maxValue = totalTiles;
             for (int x = cellExpandX; x < gridXSize; x++)
             {
                 for (int y = cellExpandY; y < gridYSize; y++)
                 {
                     currentValue++;
                     cellCenter = gridCenter + new Vector3(x * cellSize, y * cellSize, 0f);
                     spawnTile = (Instantiate(gridCellPrefab, cellCenter, Quaternion.identity) as GameObject);
                     spawnTile.name = $"Tile {x} {y}";
                     spawnTile.transform.SetParent(imageParent.transform);
                     yield return new WaitForSeconds(delay);
                     float percentage = ((float)currentValue / maxValue) * 100f;
                     if (spawnTile != null)
                     {
                         pG.AddToArray(spawnTile);
                     }
                 }
             }
                
             if (maxValue == currentValue)
             {
                 StartCoroutine(pG.AddInPathGenerator());
                 Debug.Log("Finished");
                 StopCoroutine(startingGrid);
             }
                
             yield return null;
        }

        private void OnDrawGizmosSelected()
        {
            UpdateGrid();
            
            for (int x = cellExpandX; x < gridXSize; x++)
            {
                for (int y = cellExpandY; y < gridYSize; y++)
                {
                    cellCenter = gridCenter + new Vector3(x * cellSize, y * cellSize, 0f);
                    Gizmos.color = Color.green;
                    Gizmos.DrawWireCube(cellCenter, new Vector3(cellSize, cellSize, 0f));
                }
            }
        }

        private void UpdateGrid()
        {
            grid = new int[gridXSize, gridXSize];
            gridCenter = transform.position + new Vector3((gridXSize - gridPositionX) * cellSize / 1, (gridYSize - gridPositionY) * cellSize / 1, 0f);
        }
    }
}
