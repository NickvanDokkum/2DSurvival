using UnityEngine;
using System.Collections;

public class Poison : MonoBehaviour {

	public int damage;
	Health health;

	void Start(){
		health = GetComponent<Health> ();
		InvokeRepeating ("Damage", 0.5f, 0.5f);
		Invoke ("DestroyThis", 3);
	}
	void Damage(){
		health.Damage (damage);
	}
	void DestroyThis(){
		Destroy (this);
	}
}
