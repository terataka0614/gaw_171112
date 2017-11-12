using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	Animator anim;
	Rigidbody2D rb2d;
	bool is_running;

	void Start ()
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
		is_running = false;
	}

	public void startRunning()
	{
		if (true == is_running) return;
		anim.SetBool("is_running", true);
		is_running = true;
	}

	public void startJump()
	{
		if (false == is_running) return;
		rb2d.AddForce(Vector2.up * 500f);
		anim.SetBool("is_jumping", true);
	}
}