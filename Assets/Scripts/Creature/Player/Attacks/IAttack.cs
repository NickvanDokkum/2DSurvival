using UnityEngine;
using System.Collections;

public interface IAttack {

	void StartAttack ();

	void SetProjectile(GameObject projectile);

	void Destroy ();
}
