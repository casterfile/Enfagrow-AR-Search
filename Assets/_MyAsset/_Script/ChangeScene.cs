﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

	public void ChangeSceneStart(string Name){
		Application.LoadLevel(Name);
	}
}
