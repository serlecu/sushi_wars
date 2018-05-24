using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUPRINCIPAL : MonoBehaviour {

	public void Play(){
		SceneManager.LoadScene ("PLAYMODE");

	}


	public void Intructions(){
		SceneManager.LoadScene ("INSTRUCTIONS");
    



}

		public void Quit(){
			Application.Quit();
			UnityEditor.EditorApplication.isPlaying=false;

	}
     }


