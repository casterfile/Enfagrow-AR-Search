using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
         // this object was clicked - do something
		GlobalVar.CountScore = GlobalVar.CountScore + 1;
		print("Count Number: "+ GlobalVar.CountScore);
		if(gameObject.tag == "blue"){
			GlobalVar.CountScoreBlue++;
		}else if(gameObject.tag == "yellow"){
			GlobalVar.CountScoreYellow++;
		}


     	Destroy (this.gameObject);
  } 
}
