using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]

public class DragDrop : MonoBehaviour {

	private Vector3 offset;
	bool first = true;


	void OnMouseDown()
	{

		offset = gameObject.transform.position -
			Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
	}

	////////////////////////////////////////////////
	////////////////////////////////////////////////


	Vector2 startPos, endPos, direction;
	float touchTimeStart, touchTimeFinish, timeInterval;

	[RangeAttribute(0.05f, 1f)]
	public float throwForse = 0.3f;
	// Update is called once per frame

	void OnMouseDrag()
	{
		if (first)
		{
			touchTimeStart = Time.time;
			//startPos = Input.GetTouch(0).position;
			first = false;

			startPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
			transform.position = Camera.main.ScreenToWorldPoint(startPos) + offset;
		}
		else
		{
			touchTimeFinish = Time.time;
			timeInterval = touchTimeFinish - touchTimeStart;
			//endPos = Input.GetTouch(0).position;
			endPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
			direction = startPos - endPos;
			gameObject.GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * throwForse);

		}

//		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
//		transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
	}
}