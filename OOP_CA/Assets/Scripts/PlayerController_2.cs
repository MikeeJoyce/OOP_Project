using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2 : MonoBehaviour {

    

    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Left;
    public KeyCode Right;

    [SerializeField]
    private float movespeed;

    private Vector2 direction;

    



	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        GetInput();
        Move();

    }

    public void Move()
    {
        transform.Translate(direction * movespeed * Time.deltaTime);
    }

    private void GetInput()
    {

        direction = Vector2.zero;

        if(Input.GetKey(Up))
        {
            direction += Vector2.up;
        }

        if(Input.GetKey(Down))
        {
            direction += Vector2.down;
        }

        if(Input.GetKey(Right))
        {
            direction += Vector2.right;
        }

        if(Input.GetKey(Left))
        {
            direction += Vector2.left;
        }
    }
}


