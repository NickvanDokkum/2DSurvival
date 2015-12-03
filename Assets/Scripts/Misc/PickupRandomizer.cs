using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupRandomizer : MonoBehaviour {

	public List<Sprite> sprites = new List<Sprite>();
	public List<GameObject> projectiles = new List<GameObject>();
	IUpgrade iUpgrade;
	int number;

	void Awake() {
		number = Random.Range(0, 6);
		if (number >= 3) {
			projectiles.Clear();
		}
		//GetComponent<SpriteRenderer> ().sprite = sprites [number];
		Debug.Log (number);
		sprites.Clear ();
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("hit");
			if (number == 0) {
				SpreadShot spreadshot = other.gameObject.AddComponent<SpreadShot>();
				spreadshot.SetProjectile(projectiles[0]);
			}
			else if (number == 1) {
				PoisonShot poisonShot = other.gameObject.AddComponent<PoisonShot>();
				poisonShot.SetProjectile(projectiles[1]);
			}
			else if (number == 2) {
				FlameThrower flameThrower = other.gameObject.AddComponent<FlameThrower>();
				flameThrower.SetProjectile(projectiles[2]);
				flameThrower.SetFire(projectiles[3]);
			}
			else if (number == 3) {
				other.gameObject.AddComponent<Regen>();
				Debug.Log(other.gameObject.GetComponent<Regen>());
			}
			else if (number == 4) {
				other.gameObject.AddComponent<Shield>();
				Debug.Log(other.gameObject.GetComponent<Shield>());
			}
			else if (number == 5) {
				other.gameObject.AddComponent<Speedup>();
				Debug.Log(other.gameObject.GetComponent<Speedup>());
			}
			Destroy(gameObject);
		}
	}
}
