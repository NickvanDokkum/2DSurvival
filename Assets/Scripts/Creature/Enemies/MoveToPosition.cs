using UnityEngine;
using System.Collections;

public class MoveToPosition : MonoBehaviour {

	AStarPathfinding Pathfinding;
	Vector2 targetPos;
	Movement movement;
	public int speed;

	void Awake(){
		movement = GetComponent<Movement> ();
		Pathfinding = GetComponent<AStarPathfinding> ();
	}

	public void StartWalking(Vector2 target){
		targetPos = target;
	}

	void FixedUpdate(){
		if (targetPos != new Vector2 (9999999, 9999999)) {
			Vector2 movementVector = targetPos - new Vector2 (transform.position.x, transform.position.y);
			movementVector.Normalize ();
			movementVector = (movementVector / 10) * speed;
			movement.ChangeSpeed (movementVector);
			Vector2 difference = targetPos - new Vector2 (transform.position.x, transform.position.y);
			if (movementVector.x != 0) {
				if (movementVector.x > 0 && difference.x < movementVector.x) {
					Done ();
				}
				else if (movementVector.x < 0 && difference.x > movementVector.x) {
					Done ();
				}
			}
			else if (movementVector.y != 0) {
				if (movementVector.y > 0 && difference.y < movementVector.y) {
					Done ();
				}
				else if (movementVector.y < 0 && difference.y > movementVector.y) {
					Done ();
				}
			}
		}
	}
	void Done(){
		movement.ChangeSpeed (new Vector2(0,0));
		targetPos = new Vector2(9999999,9999999);
		Pathfinding.FindPath ();
	}
}
