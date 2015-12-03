using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridVisualiser : MonoBehaviour {
	
	int[,] gridMap;

	public GameObject playerObject;
	public GameObject tileObject;
	public GameObject wallObject;
	public GameObject powerupObject;
	public GameObject enemySpawnpoint;
	GridSystem gridSystem;

	public void Visualize (){
		GameObject parentTiles = new GameObject("Tiles");
		parentTiles.transform.SetParent(transform);

		GameObject parentWalls = new GameObject("Walls");
		parentWalls.transform.SetParent(transform);

		GameObject parentPowerup = new GameObject("Powerups");
		parentPowerup.transform.SetParent(transform);

		gridSystem = GetComponent<GridSystem> ();
		gridMap = gridSystem.GetGrid();

		for (int x = 0; x < gridMap.GetLength(0); x++){
			for (int y = 0; y < gridMap.GetLength(1); y++){
				if(gridMap[x, y] == 0){
					GameObject tile = Instantiate(tileObject);
					tile.transform.position = new Vector3(x, y, 1);
					tile.transform.parent = parentTiles.transform;
				}
				else if (gridMap[x, y] == 1){
					GameObject wall = Instantiate(wallObject);
					wall.transform.position = new Vector3(x, y, 0);
					wall.transform.parent = parentWalls.transform;
				}
				else if (gridMap[x, y] == 2){
					GameObject _player = Instantiate(playerObject);
					_player.transform.position = new Vector3(x, y, -1);
				}
				else if (gridMap[x, y] == 4){
					GameObject powerup = Instantiate(powerupObject);
					powerup.transform.position = new Vector3(x, y, -1);
					powerup.transform.parent = parentPowerup.transform;
				}
				else if (gridMap[x,y] == 5){
					GameObject spawnpoint = Instantiate(enemySpawnpoint);
					spawnpoint.transform.position = new Vector3(x,y,-1);
				}
			}
		}
		transform.position = new Vector3 (transform.position.x - (int)gridMap.GetLength (0) / 2, transform.position.y - (int)gridMap.GetLength (1) / 2, transform.position.z);
		Destroy (this);
	}
}