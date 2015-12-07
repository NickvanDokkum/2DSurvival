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
		path = new List<Node> ();
		path = aStar.Path (transform.position);
		bool moving = false;
		if (path.Count > 0) {
			moveToPosition.StartWalking (new Vector2(path [0].worldPosition.x, path [0].worldPosition.y));
			moving = true;
		}
		if(path.Count == 0 || moving == false) {
			Invoke("FindPath", 0.5f);
		}
	}
}
