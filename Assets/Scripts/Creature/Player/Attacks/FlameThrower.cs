using UnityEngine;
using System.Collections;

public class FlameThrower : MonoBehaviour, IAttack {

	public double attackSpeed = 0.1;
	bool attackReady = true;
	public GameObject fire;
	GameObject fireObject;

	void Start(){
		GetComponent<Controlls> ().SetIAttack (this);
		fireObject = Instantiate (fire);
		fireObject.SetActive (false);
	}

	public void StartAttack(){
		if (attackReady) {
			fireObject.SetActive(true);
			Invoke("ReadyAttack", (float)attackSpeed);
			attackReady = false;
		}
	}
	
	void Update(){
		if (attackReady) {
			fireObject.SetActive (false);
		}
		else {
			fireObject.transform.position = transform.position;
			Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = Input.mousePosition - pos;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
			fireObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}
	}
	void ReadyAttack(){
		attackReady = true;
	}
	public void Destroy(){
		Destroy (fireObject);
		Destroy (this);
	}
}