using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public double speed;
	public double decayTime = 1;
	public int damage;
	public int strengthKnockback;

	void Start(){
		Invoke ("DestroyThis", (float)decayTime);
	}
	void DestroyThis(){
		Destroy (this.gameObject);
	}
	void Update(){
		transform.Translate (Vector2.up * (float)speed, Space.Self);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<Health>().DamageKnockback(damage, new Vector2(transform.position.x,transform.position.y), strengthKnockback);
		}
		DestroyThis ();
	}
	void OnCollisionEnter2D(Collision2D other){
		DestroyThis ();
	}
}
