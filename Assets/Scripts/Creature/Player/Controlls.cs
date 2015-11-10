using UnityEngine;
using System.Collections;

public class Controlls : MonoBehaviour {

	Movement movement;
	Attack attack;

	void Awake () {
		movement = GetComponent<Movement> ();
		attack = GetComponent<Attack> ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.ChangeSpeed(new Vector2(Input.GetAxis ("Horizontal"),Input.GetAxis("Vertical")));
		if(Input.GetButtonDown("Fire")){
			attack.StartAttack();
		}
	}
}
