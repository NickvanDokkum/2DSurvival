using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour, IUpgrade, IDefence {

	int shield = 3;
	Health health;
	
	void Start(){
		health = GetComponent<Health> ();
		health.damageReduction += shield;
		GetComponent<IDefence> ().DestroyThis();
	}
	public void DestroyThis(){
		health.damageReduction -= shield;
		Destroy (this);
	}
}
