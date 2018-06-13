using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {
    public float speed = 0.1f;
    public int playerNumber= 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerNumber == 1){
            CheckPlayer1Inputs();
        }else{
            CheckPlayer2Inputs();
        }
      }

    void CheckPlayer1Inputs(){
        if (Input.GetKey(KeyCode.LeftArrow)){
            Vector2 position = transform.position;
            position.x -= speed;
            transform.position = position;
            }
    
        if (Input.GetKey(KeyCode.RightArrow)) {
                Vector2 position = transform.position;
                position.x += speed;
                transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
            {
                Vector2 position = transform.position;
                position.y -= speed;
                transform.position = position;
            }

        if (Input.GetKey(KeyCode.UpArrow))
            {
                Vector2 position = transform.position;
                position.y+= speed;
                transform.position = position;
        }
    }

            void CheckPlayer2Inputs() {
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 position = transform.position;
            position.x -= speed;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 position = transform.position;
            position.x += speed;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.X))
        {
            Vector2 position = transform.position;
            position.y -= speed;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector2 position = transform.position;
            position.y += speed;
            transform.position = position;
        }
    }
}