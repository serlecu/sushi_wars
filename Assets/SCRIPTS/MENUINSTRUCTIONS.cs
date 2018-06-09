using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MENUINSTRUCTIONS : MonoBehaviour {

	public void Play(){
		SceneManager.LoadScene ("PLAYMODE");
	}


	public void Back(){
		SceneManager.LoadScene ("PANTALLA 2");
	}


}