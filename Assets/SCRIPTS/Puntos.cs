using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntos : MonoBehaviour {

	public GameObject contadorL;
	public GameObject contadorR;

	int OldPuntuacionL=0;
	int NewPuntuacionL;
	int OldPuntuacionR=0;
	int NewPuntuacionR;



	public void PuntosL(){

		//OldPuntuacionL = int.Parse(contadorR.GetComponent<Text> ().text);
		NewPuntuacionL = OldPuntuacionL++;
		contadorL.GetComponent<Text> ().text = (NewPuntuacionL.ToString ());

		if (NewPuntuacionL == 8) {
			OldPuntuacionL = 0;
			SceneManager.LoadScene ("PANTALLA 2");
		}
	
	}

	public void PuntosR(){

		//OldPuntuacionR = int.Parse(contadorR.GetComponent<Text> ().text);
		NewPuntuacionR = OldPuntuacionR++;
		contadorR.GetComponent<Text> ().text = (NewPuntuacionR.ToString ());

		if (NewPuntuacionR == 8) {
			OldPuntuacionR = 0;
			SceneManager.LoadScene ("PANTALLA 2");

		}
	}
}
