using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AStarPathfinding : MonoBehaviour {

	AStar aStar;
	List<Node> path = new List<Node>();
	MoveToPosition moveToPosition;

	void Awake() {
		aStar = GameObject.Find ("A*").GetComponent<AStar> ();
		moveToPosition = GetComponent<MoveToPosition> ();
	}
	void Start(){
		FindPath ();
	}
	public void FindPath(){
		path.Clear ();
		path = aStar.Path (transform);
		//Debug.Log(transform.position + " " + path[0].worldPosition);
		moveToPosition.StartWalking (new Vector2(path [0].worldPosition.x, path [0].worldPosition.y));
	}
}
