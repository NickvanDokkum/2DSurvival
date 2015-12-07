using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WalkSprites : MonoBehaviour {

	public List<Sprite> sprites = new List<Sprite>();
	Movement movement;
	SpriteRenderer spriteRenderer;
	int currentSprite;
	int curDir = 99;
	public float timeBetweenSprites;

	void Awake(){
		movement = GetComponentInParent<Movement> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	void FixedUpdate(){
		if (curDir != movement.direction) {
			curDir = movement.direction;
			currentSprite = curDir * 2 + 1;
			CancelInvoke("ChangeSprite");
			InvokeRepeating("ChangeSprite", 0, timeBetweenSprites);
			if(curDir == 4){
				currentSprite = 4;
			}
		}
	}
	void ChangeSprite(){
		if (currentSprite != 4) {
			if (currentSprite % 2 == 1) {
				currentSprite ++;
			}
			else {
				currentSprite --;
			}
		}
		spriteRenderer.sprite = sprites [currentSprite];
	}
}
