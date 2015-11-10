using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public double speed;
	public double decayTime = 1;

	void Start(){
		Invoke ("DestroyThis", (float)decayTime);
	}
	void DestroyThis(){
		Destroy (this.gameObject);
	}
	void Update(){
		transform.Translate (Vector2.up * (float)speed, Space.Self);
	}
}
