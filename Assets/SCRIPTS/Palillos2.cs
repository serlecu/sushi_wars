using UnityEngine;

public class Palillos2 : MonoBehaviour {

	bool wasJustClicked = true;
	bool canMove;
	Vector2 playerSize;

	Rigidbody2D rb;

	public Transform BoundaryHolder1;

	Boundary playerBoundary;

	struct Boundary
	{
		public float Up1, Down1, Left1, Right1;

		public Boundary(float up, float down, float left, float right)
		{
			Up1 = up; Down1= down; Left1=left; Right1=right;
		}
	}

	// Use this for initialization
	void Start () {
		playerSize = GetComponent<SpriteRenderer>().bounds.extents;
		rb = GetComponent<Rigidbody2D> ();

		playerBoundary = new Boundary (BoundaryHolder1.GetChild (0).position.y,
			BoundaryHolder1.GetChild (1).position.y,
			BoundaryHolder1.GetChild (2).position.x,
			BoundaryHolder1.GetChild (3).position.x);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if (wasJustClicked)
			{
				wasJustClicked = false;

				if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
					mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
					(mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y ||
						mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y))
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
				Vector2 clampedMousePos =  new Vector2 (Mathf.Clamp(mousePos.x, playerBoundary.Left1, playerBoundary.Right1),
					Mathf.Clamp(mousePos.y, playerBoundary.Down1, playerBoundary.Up1));
				rb.MovePosition(clampedMousePos);
			}
		}
		else
		{
			wasJustClicked = true;
		}
	}
}