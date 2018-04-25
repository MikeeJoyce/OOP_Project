using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed;
	public KeyCode Up;
	public KeyCode Down;
	public KeyCode Left;
	public KeyCode Right;


	private Animator anim;

	private bool playerMoving;
	private Vector2 lastMove;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();


	}

	// Update is called once per frame
	void Update () {

		playerMoving = false;


		if (Input.GetKey(Right) || Input.GetKey(Left))
		{
			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0F, 0F));
			playerMoving = true;
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
		}

		if (Input.GetKey(Up) || Input.GetKey(Down))
		{
			transform.Translate (new Vector3 (0F, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0F));
			playerMoving = true;
			lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
		}


		anim.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
		anim.SetBool ("PlayerMoving", playerMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);

		playerMoving = false;

	}
}
