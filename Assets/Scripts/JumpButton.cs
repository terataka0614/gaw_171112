using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
	GameObject obj_character;
	Character character;
	void Start()
	{
		obj_character = GameObject.Find("Character");
		character = obj_character.GetComponent<Character>();
	}

	public void characterJump()
	{
		character.startJump();
	}
}
