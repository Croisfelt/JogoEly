using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public int coinValue = 1;
	
	private void OnTriggerEnder2D(Collider2D col){

		if(col.gameObject.CompareTag("Coins")){

			Destroy(col.gameObject);
		}

		if(col.gameObject.CompareTag("Player")){

			ScoreManager.instance.ChangeScore(coinValue);
		}
	}
}

	// Use this for initialization