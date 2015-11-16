using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int health;
	public int damageReduction;
	int maxHealth;

	void Start(){
		maxHealth = health;
	}
	public void DamageKnockback(int damage, Vector2 knockbackPosition, float knockbackStrength){
		Damage (damage);
		Vector2 knockbackVec = new Vector2(transform.position.x - knockbackPosition.x, transform.position.y - knockbackPosition.y).normalized;
		knockbackStrength /= 10;
		if(knockbackStrength >= 10 || knockbackStrength <= 0){
			knockbackVec /= -knockbackStrength + 10;
		}
		transform.position = new Vector2(transform.position.x + knockbackVec.x, transform.position.y + knockbackVec.y);
	}
	public void Damage(int damage){
		health -= damage;
		if (health <= 0) {
			Death();
		}
		Debug.Log (health);
	}
	public void Heal(int heal){
		health += heal;
		if (health > maxHealth) {
			health = maxHealth;
		}
	}
	void Death(){
		Destroy (gameObject);
	}
}
