using UnityEngine;
using System.Collections;

public class SpreadShot : MonoBehaviour, IUpgrade, IAttack {

	public double attackSpeed = 1;
	bool attackReady = true;
	GameObject bullet;
	
	void Start(){
		GetComponent<Controlls> ().SetIAttack (this);
	}
	public void StartAttack(){
		if (attackReady == true) {
			for (int i = 0; i < 3; i++) {
				GameObject bulletObject = Instantiate (bullet);
				bulletObject.transform.position = transform.position;
				Vector3 pos = Camera.main.WorldToScreenPoint (transform.position);
				Vector3 dir = Input.mousePosition - pos;
				float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg - 70 - (20 * i);
				bulletObject.transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
			}
			Invoke("ReadyAttack", (float)attackSpeed);
			attackReady = false;
		}
	}
	void ReadyAttack(){
		attackReady = true;
	}
	public void SetProjectile(GameObject projectile){
		bullet = projectile;
	}
	public void Destroy(){
		Destroy (this);
	}
}
