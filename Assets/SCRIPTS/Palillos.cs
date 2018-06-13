using UnityEngine;

public class Palillos : MonoBehaviour {

	bool wasJustClicked = true;
	bool canMove;
	Vector2 playerSize;

	Rigidbody2D rb;

	public Transform BoundaryHolder;

	Boundary playerBoundary;

	struct Boundary
	{
		public float Up, Down, Left, Right;

		public Boundary(float up, float down, float left, float right)
		{
			Up = up; Down= down;Left=left;Right=right;
		}
	}

	// Use this for initialization
	void Start () {
		playerSize = GetComponent<SpriteRenderer>().bounds.extents;
		rb = GetComponent<Rigidbody2D> ();


		playerBoundary = new Boundary (BoundaryHolder.GetChild (0).position.y,
			BoundaryHolder.GetChild (1).position.y,
			BoundaryHolder.GetChild (2).position.x,
			BoundaryHolder.GetChild (3).position.x);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0))
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));

			if (wasJustClicked)
			{
				wasJustClicked = false;
//				if ((mousePos.x >= gameObject.transform.position.x && mousePos.x < gameObject.transform.position.x + playerSize.x ||
//					mousePos.x <= gameObject.transform.position.x && mousePos.x > gameObject.transform.position.x - playerSize.x) &&
//					(mousePos.y >= gameObject.transform.position.y && mousePos.y < gameObject.transform.position.y + playerSize.y ||
//						mousePos.y <= gameObject.transform.position.y && mousePos.y > gameObject.transform.position.y - playerSize.y))
//				{
					if ((p.x >= gameObject.transform.position.x && p.x < gameObject.transform.position.x + playerSize.x ||
						p.x <= gameObject.transform.position.x && p.x > gameObject.transform.position.x - playerSize.x) &&
						(p.y >= gameObject.transform.position.y && p.y < gameObject.transform.position.y + playerSize.y ||
							p.y <= gameObject.transform.position.y && p.y > gameObject.transform.position.y - playerSize.y))
					{
						
					canMove = true;
				}
				else
				{
					canMove = false;
				}
			}

			if (canMove)
			{
//				Vector2 clampedMousePos =  new Vector2 (Mathf.Clamp(mousePos.x, playerBoundary.Left, playerBoundary.Right),
//					Mathf.Clamp(mousePos.y, playerBoundary.Down, playerBoundary.Up));
//				rb.MovePosition(clampedMousePos);

				Vector2 MousePos =  new Vector2 (mousePos.x, mousePos.y);
				rb.MovePosition(MousePos);

			}
		}
		else
		{
			wasJustClicked = true;
		}
	}
}