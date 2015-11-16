using UnityEngine;
using System.Collections;

public class PoisonTarget : MonoBehaviour {

	public int damage;

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy") {
			other.gameObject.AddComponent<Poison>().damage = damage;
		}
	}
}
