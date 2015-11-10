using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	Vector2 currentSpeed;
	public double speed;
	public double direction;

	public void ChangeSpeed(Vector2 speed){
		currentSpeed = speed;
		if (speed.x != 0) {
			if (speed.x > 0) {
				direction = 3;
				if (speed.y > 0) {
					direction += 0.5f;
				}
				else if (speed.y < 0) {
					direction -= 0.5f;
				}
			}
			else if (speed.x < 0) {
				direction = 1;
				if (speed.y > 0) {
					direction -= 0.5f;
				}
				else if (speed.y < 0) {
					direction += 0.5f;
				}
			}
		}
		else if (speed.y != 0) {
			if(speed.y > 0){
				direction = 0;
			}
			else {
				direction = 2;
			}
		}
	}

	void Update(){
		transform.Translate (currentSpeed * (float)speed / 15);
	}
}
