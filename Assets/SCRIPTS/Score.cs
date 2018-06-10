using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

	public enum Puntos {
		P1Puntos, P2Puntos
	}

	public Text p1PuntosText, p2PuntosText;
	private int p1Puntos, p2Puntos;

	public void Increment(Puntos whichScore)
	{
		if (whichScore == Puntos.P1Puntos)
			p1PuntosText.text = (++p1Puntos).ToString();
		else
			p2PuntosText.text = (++p2Puntos).ToString();
	}


}
