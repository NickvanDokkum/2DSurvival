using UnityEngine;
using System.Collections;

public class NoDefence : MonoBehaviour, IUpgrade, IDefence {

	public void DestroyThis(){
		Destroy (this);
	}
}
