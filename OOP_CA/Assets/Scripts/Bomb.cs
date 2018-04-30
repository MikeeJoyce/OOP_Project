using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour {

	public float countdown = 2f;
	float tilesize = 1;
    public GameObject player1;
	public GameObject player2;
    public int ponepoints;
    public int ptwopoints;
    public Text countText;


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
				if (player1.transform.position.x < (transform.position.x + tilesize / 2) &&
				   player1.transform.position.x > (transform.position.x - tilesize / 2)) {
					Destroy (player1);
                    ptwopoints += ptwopoints;
				}

				//if the player's y pos is close to ours we kill him
				if (player1.transform.position.y < (transform.position.y + tilesize / 2) &&
					player1.transform.position.y > (transform.position.y - tilesize / 2)) {
					Destroy (player1);
                    ptwopoints += ptwopoints;
                }
					
			}

			//check if we can kill player 2
			if (player2 != null && Vector3.Distance (transform.position, player2.transform.position) 
				< (tilesize * 2.5 )) {

				//if the player's x pos is close to ours we kill him
				if (player2.transform.position.x < (transform.position.x + tilesize / 2) &&
					player2.transform.position.x > (transform.position.x - tilesize / 2)) {
					Destroy (player2);
                    ponepoints += ponepoints;
                }

				//if the player's y pos is close to ours we kill him
				if (player2.transform.position.y < (transform.position.y + tilesize / 2) &&
					player2.transform.position.y > (transform.position.y - tilesize / 2)) {
					Destroy (player2);
                    ponepoints += ponepoints;
                }
			}

			Destroy (gameObject);

		}
	}

    void SetCountText()
    {
        countText.text = "Player One Score: " + ponepoints.ToString();
        countText.text = "Player Two Score: " + ptwopoints.ToString();
    }


}
