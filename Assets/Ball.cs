using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	Component Collision;
	Component Sprite;

	public float speed = 30;
	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight) {
		return (ballPos.y - racketPos.y) / racketHeight;
	}
		

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
	}
		
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D col) {
	
		if (col.gameObject.name == "RacketLeft") {
			float y = hitFactor (transform.position, col.transform.position, col.collider.bounds.size.y);

			Vector2 dir = new Vector2 (1, y).normalized;

			GetComponent<Rigidbody2D> ().velocity = dir * speed;
		}
	}
}
