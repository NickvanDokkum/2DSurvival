using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupRandomizer : MonoBehaviour {

	public Sprite[] sprites;
	public List<MonoBehaviour> upgrades = new List<MonoBehaviour> ();
	string upgrade;
	int number;

	void Awake() {
		number = Random.Range(0, upgrades.Count);
		GetComponent<SpriteRenderer> ().sprite = sprites [number];
		upgrade = upgrades [number].name;
		upgrades.Clear ();
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			//other.gameObject.AddComponent<upgrades[number]>();
		}
	}
}
