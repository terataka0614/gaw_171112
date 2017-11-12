using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
	const float LOOP_START_X = -9.85f;
	const float LOOP_END_X = -27.0f;
	const float POSITION_Y = -3.712f;
	const float MOVE_SPEED = 4.0f;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D>();
		this.transform.position = new Vector2(LOOP_START_X, POSITION_Y);
	}

	Rigidbody2D rb2d;
	public void move()
	{
		if (this.transform.position.x <= LOOP_END_X) {
			this.transform.position = new Vector2(LOOP_START_X, POSITION_Y);
		} else {
			rb2d.velocity = new Vector2(MOVE_SPEED * (-1), rb2d.velocity.y);
		}
	}
}
