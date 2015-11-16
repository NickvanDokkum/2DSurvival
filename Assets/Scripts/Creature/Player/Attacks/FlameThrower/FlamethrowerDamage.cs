using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FlamethrowerDamage : MonoBehaviour {
	
	public int damage;
	public double attackSpeed;
	List<GameObject> targets = new List<GameObject>();

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy") {
			targets.Add(other.gameObject);
			Debug.Log(other.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy") {
			targets.Remove(other.gameObject);
		}
	}
	void Damage(){
		for(int i = 0; i < targets.Count; i++){
			targets[i].GetComponent<Health>().Damage(damage);
		}
	}
	void OnDisable(){
		targets.Clear ();
		CancelInvoke ("Damage");
	}
	void OnEnable(){
		InvokeRepeating ("Damage", 0, (float)attackSpeed);
	}
}
