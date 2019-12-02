using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Image BlueBarFill,YellowBarFill;
	float timeLeft = 20;
	public Text Timer;
	// Use this for initialization
	void Start () {
		BlueBarFill.fillAmount = 0;
		YellowBarFill.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// BlueBarFill.fillAmount -=  Time.deltaTime;
		// if(GlobalVar.CountScoreYellow == 1){
		// 	YellowBarFill.fillAmount = .5f;
		// }
		// if(GlobalVar.CountScoreYellow == 2){
		// 	YellowBarFill.fillAmount = 1.0f;
		// }

		if(GlobalVar.CountScore >= 10){
			EndGame();
		}

		float Data = 0.2f * GlobalVar.CountScoreBlue;
		BlueBarFill.fillAmount = Data; 
		float Data2 = 0.2f * GlobalVar.CountScoreYellow;
		YellowBarFill.fillAmount = Data2; 
		// print("Counter: "+  Data) ;


		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			EndGame();
		}else{
			Timer.text = ""+(int)timeLeft;
		}
	}

	void EndGame(){
		Application.LoadLevel("Scene_00");
	}
}
