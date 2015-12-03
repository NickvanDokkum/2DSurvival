using UnityEngine;
using System.Collections;

public class DamageOnTouch : MonoBehaviour {

	public int damage;

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Health>().DamageKnockback(damage, transform.position, 0);
		}
	}
}
