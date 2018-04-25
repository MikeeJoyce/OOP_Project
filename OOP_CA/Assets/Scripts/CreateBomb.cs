using UnityEngine;
using UnityEngine.Tilemaps;

public class CreateBomb : MonoBehaviour 
{
	public Tilemap tilemap;

	public GameObject bombPrefab;
	public GameObject player;

		
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Vector3 worldPos = player.transform.position;
			Vector3Int cell = tilemap.WorldToCell(worldPos);
			Vector3 cellCenterPros = tilemap.GetCellCenterWorld(cell);

			Instantiate(bombPrefab, cellCenterPros, Quaternion.identity);
		}
	}
}