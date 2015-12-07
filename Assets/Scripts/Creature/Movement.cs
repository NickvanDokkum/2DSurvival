using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	Vector2 currentSpeed;
	public float speed;
	public int direction;

	public void ChangeSpeed(Vector2 speedVec){
		currentSpeed = speedVec;
		if (speedVec.x < 0) {
			speedVec.x = -speedVec.x;
		}
		if (speedVec.y < 0) {
			speedVec.y = -speedVec.y;
		}
		if (speedVec.y > speedVec.x) {
			if (currentSpeed.y > 0) {
				direction = 0;
			}
			else {
				direction = 2;
			}
		}
		else if (speedVec.y < speedVec.x) {
			if (currentSpeed.x > 0) {
				direction = 1;
			}
			else {
				direction = 3;
			}
		}
		else {
			direction = 4;
		}
	}
	void FixedUpdate(){
		transform.Translate (currentSpeed * speed / 15);
	}
}