using UnityEngine;
using System.Collections;

public class SpawnCharacters : MonoBehaviour {
	
	Grid grid;
	public GameObject player;
	public GameObject enemy;

	void Awake(){
		grid = GetComponent<Grid> ();
	}
	void LateUpdate () {
		if(Input.GetMouseButtonDown (0)){
			Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(pos, transform.position);
			if (hit.collider != null) {
				Node node = grid.NodeFromWorldPoint(hit.transform.position);
				if(node.walkable){
					Instantiate(enemy, node.worldPosition, transform.rotation);
				}
			}
		}
		if(Input.GetMouseButtonDown(1)){
			Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(pos, transform.position);
			if (hit.collider != null) {
				Node node = grid.NodeFromWorldPoint(hit.transform.position);
				if(node.walkable){
					player.transform.position = new Vector2(node.worldPosition.x, node.worldPosition.y);
				}
			}
		}
	}
}
