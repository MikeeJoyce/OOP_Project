using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

	public GameObject ExplosionPrefab;
	public GameObject Player;

	void  OnCollisionEnter(Collision ExplosionPrefab) {
		if(ExplosionPrefab.gameObject.tag == "Player") {
			Debug.Log ("ded");
			Destroy(gameObject);
		}
	}
}
