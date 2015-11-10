using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public double attackSpeed;
	bool attackReady = true;
	public GameObject bullet;
	Movement movement;

	void Awake(){
		movement = GetComponent<Movement> ();
	}
	public void StartAttack(){
		if (attackReady == true) {
			Debug.Log("Attack " + movement.direction);
			GameObject bulletObject = Instantiate(bullet);
			bulletObject.transform.position = transform.position;
			bulletObject.transform.rotation = Quaternion.Euler(0, 0, (float)movement.direction * 90);
			Invoke("ReadyAttack", (float)attackSpeed);
			attackReady = false;
		}
	}
	void ReadyAttack(){
		attackReady = true;
	}
}
