﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
	public void sceneMoved(string name)
	{
		SceneManager.LoadScene(name);
	}
}
