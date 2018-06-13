using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Auto Move")]
[RequireComponent(typeof(Rigidbody2D))]
public class AutoMove : Physics2DObject
{

	bool wasJustClicked = true; //para anular el movimiento cuando se clique
	Vector2 playerSize;


	// These are the forces that will push the object every frame
	// don't forget they can be negative too!
	public Vector2 direction = new Vector2(1f, 0f);


	//is the push relative or absolute to the world?
	public bool relativeToRotation = true;

	
	// FixedUpdate is called once per frame
	void FixedUpdate ()
	{

		if (wasJustClicked) 
		{
			if(relativeToRotation) 
			{
				rigidbody2D.velocity = direction ;

			} else 
			{
				//rigidbody2D.AddForce(direction * 2f);
				rigidbody2D.velocity = direction ;
			}

			if (Input.GetMouseButton(0)) 
			{
				Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				wasJustClicked = false;

				if ((mousePos.x >= gameObject.transform.position.x && mousePos.x < gameObject.transform.position.x + playerSize.x ||
				    mousePos.x <= gameObject.transform.position.x && mousePos.x > gameObject.transform.position.x - playerSize.x) &&
				    (mousePos.y >= gameObject.transform.position.y && mousePos.y < gameObject.transform.position.y + playerSize.y ||
				    mousePos.y <= gameObject.transform.position.y && mousePos.y > gameObject.transform.position.y - playerSize.y)) {

//					canMove = true;
				} else 
				{
//					canMove = false;
				}
			} else 
			{
				

			}

		}
	}


	//Draw an arrow to show the direction in which the object will move
	void OnDrawGizmosSelected()
	{
		if(this.enabled)
		{
			float extraAngle = (relativeToRotation) ? transform.rotation.eulerAngles.z : 0f;
			Utils.DrawMoveArrowGizmo(transform.position, direction, extraAngle);
		}
	}
}
