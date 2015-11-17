using UnityEngine;
using System.Collections;

public class PoisonShot : AttackNormal {

	void Start(){
		attackSpeed = 1;
	}
	public void SetProjectile(GameObject projectile){
		bullet = projectile;
	}
}