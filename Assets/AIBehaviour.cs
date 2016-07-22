using UnityEngine;
using System.Collections;

public class AIBehaviour : MonoBehaviour {

	//public Ball ball;
	public GameObject Ball ;
	public Transform CurrentTransform;
	// Use this for initialization
	void Start () {
		CurrentTransform = this.transform;

	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		CurrentTransform = this.transform;
		if (Ball.transform.position.y > CurrentTransform.position.y+1) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 1) * 16;
		}

		if (Ball.transform.position.y < CurrentTransform.position.y-1) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -1) * 16;
		}
	}
}	