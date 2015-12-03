using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pathfinding : MonoBehaviour {
	/*Grid grid;
	AStar aStar;
	List<Node> Path = new List<Node>();
	public int speed;
	Vector2 movementVector;
	Movement movement;
	Vector2 nextPos;

	void Awake(){
		GameObject AStarObject = GameObject.Find ("A*");
		aStar = AStarObject.GetComponent<AStar> ();
		grid = AStarObject.GetComponent<Grid> ();
		movement = GetComponent<Movement> ();
		InvokeRepeating ("FindPath", 0.1f, 1);
	}
	void FixedUpdate(){;
		if (Path.Count == 0) {
			FindPath();
		}
		Vector2 difference = nextPos - new Vector2(transform.position.x, transform.position.y);
		Debug.Log (difference);
		if (movementVector.x != 0) {
			Debug.Log("x!=0");
			if (movementVector.x > 0 && difference.x < movementVector.x) {
				Debug.Log("movementVector.x > 0 && difference.x < movementVector.x");
				FindPath ();
			} else if (difference.x > movementVector.x) {
				Debug.Log("difference.x > movementVector.x");
				FindPath ();
			}
		} else if (movementVector.y != 0) {
			Debug.Log("y!=0");
			if (movementVector.y > 0 && difference.y < movementVector.y) {
				Debug.Log("movementVector.y > 0 && difference.y < movementVector.y");
				FindPath ();
			} else if (difference.y < movementVector.y) {
				Debug.Log("movementVector.y < movementVector.y");
				FindPath ();
			}
		} else {
			Debug.Log("else");
			FindPath();
		}
	}
	void FindPath(){
		Path.Clear();
		Path = new List<Node> ();
		Path = aStar.Path (gameObject.transform);
		Vector2 curPos = grid.nodeToPosition(Path[0]);
		Vector2 nextPos = grid.nodeToPosition(Path[1]);
		movementVector = nextPos - curPos;
		movementVector = (movementVector / 10) * speed;
		Debug.Log (movementVector);
		//movement.ChangeSpeed (movementVector);
		Node node = grid.NodeFromWorldPoint (transform.position);
		transform.position = grid.nodeToPosition(node);
	}*/
}