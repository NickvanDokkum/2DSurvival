using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public double speed;

	void Update(){
		transform.Translate (Vector2.up * (float)speed, Space.Self);
	}
}
