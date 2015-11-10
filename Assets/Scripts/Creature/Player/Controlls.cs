	using UnityEngine;
using System.Collections;

public class Controlls : MonoBehaviour {

	Movement movement;
	IAttack attack;

	void Awake () {
		movement = GetComponent<Movement> ();
	}
	public void SetIAttack(IAttack iAttack){
		if (attack != null) {
			attack.Destroy ();
		}
		attack = iAttack;
	}
	void Update () {
		movement.ChangeSpeed(new Vector2(Input.GetAxis ("Horizontal"),Input.GetAxis("Vertical")));
		if(Input.GetKey(KeyCode.Mouse0)){
			attack.StartAttack();
		}
	}
}
