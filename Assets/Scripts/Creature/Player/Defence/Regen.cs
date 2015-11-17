using UnityEngine;
using System.Collections;

public class Regen : MonoBehaviour, IUpgrade, IDefence {

	int regen = 1;
	float time = 5;
	Health health;

	void Start(){
		health = GetComponent<Health> ();
		InvokeRepeating ("Heal", time, time);
		GetComponent<IDefence> ().DestroyThis();
	}
	void Heal(){
		health.Heal (regen);
	}
	public void DestroyThis(){
		CancelInvoke ("Heal");
		Destroy (this);
	}
}
