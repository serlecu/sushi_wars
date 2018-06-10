using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiPunto : MonoBehaviour {

	public Score ScoreScriptInstance;



	private void OnTriggerEnter2D(Collider2D other)
	{



	}





	public void P1Punto(){
		
		ScoreScriptInstance.Increment(Score.Puntos.P1Puntos);
	}

	public void P2Punto(){
		ScoreScriptInstance.Increment(Score.Puntos.P2Puntos);
	}

}
