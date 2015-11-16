using UnityEngine;
using System.Collections;

public class Speedup : Upgrade, IDefence {

	float speed = 0.1f;
	Movement movement;

	void Start () {
		movement = GetComponent<Movement> ();
		movement.speed += speed;
		GetComponent<IDefence> ().DestroyThis();
	}
	public void DestroyThis(){
		movement.speed -= speed;
		Destroy (this);
	}
}
