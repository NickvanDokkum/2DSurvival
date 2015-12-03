using UnityEngine;
using System.Collections;

public class FlameThrower : MonoBehaviour, IUpgrade, IAttack {

	public double attackSpeed = 0.1;
	public double rangedAttackSpeed = 2;
	bool attackReady = true;
	bool rangedReady = true;
	GameObject ranged;
	GameObject fireObject;

	void Start(){
		GetComponent<Controlls> ().SetIAttack (this);
		fireObject.transform.position = transform.position;
		fireObject.transform.SetParent (this.transform);
	}

	public void StartAttack(){
		if (attackReady) {
			fireObject.SetActive(true);
			Invoke("ReadyAttack", (float)attackSpeed);
			attackReady = false;
		}
		if (rangedReady) {
			GameObject rangedObject = Instantiate(ranged);
			rangedObject.transform.position = transform.position;
			Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = Input.mousePosition - pos;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
			rangedObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			Invoke("RangedReady", (float)rangedAttackSpeed);
			rangedReady = false;
		}
	}
	void RangedReady(){
		rangedReady = true;
	}
	void Update(){
		if (attackReady) {
			fireObject.SetActive (false);
		}
		else {
			Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = Input.mousePosition - pos;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
			fireObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}
	}
	void ReadyAttack(){
		attackReady = true;
	}
	public void SetProjectile(GameObject projectile){
		ranged = projectile;
	}
	public void SetFire(GameObject firePrefab){
		fireObject = Instantiate (firePrefab);
		fireObject.SetActive (false);
	}
	public void Destroy(){
		Destroy (fireObject);
		Destroy (this);
	}
}