using UnityEngine;
using System.Collections;

public class PlayerHealth : Health {

	void Death(){
		Debug.Log ("Player Death");
		Application.LoadLevel (Application.loadedLevel);
	}
}
