using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVar : MonoBehaviour {
	public static int CountScore = 0;
	public static int CountScoreYellow = 0;
	public static int CountScoreBlue = 0;
	// Use this for initialization
	void Start () {
		CountScore = 0;
		CountScoreYellow = 0;
		CountScoreBlue = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
