using UnityEngine;
using System.Collections;

public class AttackNormal : Upgrade, IAttack {

	public double attackSpeed = 0.6;
	bool attackReady = true;
	public GameObject bullet;

	void Awake(){
		GetComponent<Controlls> ().SetIAttack (this);
	}
	public void StartAttack(){
		if (attackReady == true) {
			GameObject bulletObject = Instantiate(bullet);
			bulletObject.transform.position = transform.position;
			Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = Input.mousePosition - pos;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
			bulletObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			Invoke("ReadyAttack", (float)attackSpeed);
			attackReady = false;
		}
	}
	void ReadyAttack(){
		attackReady = true;
	}
	public void Destroy(){
		Destroy (this);
	}
}
