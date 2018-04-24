using UnityEngine;
using UnityEngine.Tilemaps;

public class CreateBomb : MonoBehaviour 
{
	public Tilemap tilemap;

	public GameObject bombPrefab;

		
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Vector3 worldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector3Int cell = tilemap.WorldToCell(worldPos);
			Vector3 cellCenterPros = tilemap.GetCellCenterWorld(cell);

			Instantiate(bombPrefab, cellCenterPros, Quaternion.identity);
		}
	}
}