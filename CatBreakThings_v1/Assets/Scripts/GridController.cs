using UnityEngine;

public class GridController : MonoBehaviour
{
    public GameObject tilePrefab;
    public int gridWidth;
    public int gridHeight;
    public float tileSize;

    void Start()
    {
        // Calculate the starting position of the grid
        Vector3 startPosition = transform.position - new Vector3(gridWidth * tileSize / 2, gridHeight * tileSize / 2, 0);

        // Create a grid of tiles
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                // Instantiate a new tile and position it on the grid
                GameObject tile = Instantiate(tilePrefab, transform);
                tile.transform.position = startPosition + new Vector3(x * tileSize, y * tileSize, 0);
            }
        }
    }
}
