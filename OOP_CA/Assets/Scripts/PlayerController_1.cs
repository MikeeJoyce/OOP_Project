using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2 : MonoBehaviour {

    

    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Left;
    public KeyCode Right;
	public int playerlife;

    [SerializeField]
    private float movespeed;

    private Animator animator;


    private Vector2 direction;

    



	// Use this for initialization
	void Start () {
		playerlife = 3;
        animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        GetInput();
        Move();

    }

    public void Move()
    {
        transform.Translate(direction * movespeed * Time.deltaTime);

        if(direction.x != 0 || direction.y != 0)
        {
            Animate(direction);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
        
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

    public void Animate(Vector2 direction)
    {

        animator.SetLayerWeight(1, 1);

        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);

    }
}


