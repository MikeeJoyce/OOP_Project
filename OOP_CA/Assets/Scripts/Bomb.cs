using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour {

	public float countdown = 2f;
	float tilesize = 1;
    public GameObject player1;
	public GameObject player2;


	void Awake()
	{
		player1 = GameObject.Find("Player");
		player2 = GameObject.Find("Player 2");
    }
	
	// Update is called once per frame
	void Update () 
	{
		countdown -= Time.deltaTime;

		if (countdown <= 0f)
		{
			FindObjectOfType<MapDestroyer>().Explode(transform.position);

			//check if we can kill player 1
			if (player1 != null && Vector3.Distance(transform.position, player1.transform.position) 
				< (tilesize * 2.5 )) { 

				//if the player's x pos is close to ours we kill him
				if ((player1.transform.position.x < (transform.position.x + tilesize / 2) &&
					player1.transform.position.x > (transform.position.x - tilesize / 2)) 
					||
					(player1.transform.position.y < (transform.position.y + tilesize / 2) &&
						player1.transform.position.y > (transform.position.y - tilesize / 2)))
				{
					player1.GetComponent<PlayerController_2> ().playerlife--;
                }

                    Destroy (gameObject);
            }

			//check if we can kill player 2
			if (player2 != null && Vector3.Distance (transform.position, player2.transform.position) 
				< (tilesize * 2.5 )) {

				//if the player's x pos is close to ours we kill him
				if ((player2.transform.position.x < (transform.position.x + tilesize / 2) &&
					player2.transform.position.x > (transform.position.x - tilesize / 2)) 
					||
					(player2.transform.position.y < (transform.position.y + tilesize / 2) &&
						player2.transform.position.y > (transform.position.y - tilesize / 2)))
				{
					player2.GetComponent<PlayerController_2> ().playerlife--;
				}

			}

				Destroy (gameObject);
		}

	
		if (player1.GetComponent<PlayerController_2> ().playerlife <= 0) 
		{
			Destroy (player1);
		}
		if (player2.GetComponent<PlayerController_2> ().playerlife <= 0) 
		{
			Destroy (player2);
		}


    }
}
