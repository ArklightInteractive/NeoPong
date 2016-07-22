using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int PlayerScore = 0;
	public int EnemyScore = 0;
	public GameObject ball;

	public GameObject PText;
	public GameObject EText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		//Check collision name
		Debug.Log("collision name = " + col.gameObject.name);


		if(col.gameObject.name == "WallLeft")
		{
			gameObject.GetComponent<Renderer> ().enabled = false;
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			gameObject.GetComponent<TrailRenderer> ().enabled = false;

			EnemyScore = EnemyScore + 1;
			Debug.Log("EnemyScore" + EnemyScore);
			EText.GetComponent<Text> ().text = "Score:" + EnemyScore.ToString();
			new WaitForSeconds (5);
			ball.transform.position = new Vector2(50,-1);
			Instantiate (ball);
			//ball.transform.position = new Vector2(5,-1);
			ball.transform.position = new Vector2(5,-1);

			gameObject.GetComponent<Renderer> ().enabled = true;
			gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			gameObject.GetComponent<TrailRenderer> ().enabled = true;
		}

		if(col.gameObject.name == "WallRight")
		{
			gameObject.GetComponent<Renderer> ().enabled = false;
			gameObject.GetComponent<Renderer> ().enabled = false;
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			gameObject.GetComponent<TrailRenderer> ().enabled = false;

			PlayerScore = PlayerScore + 1;
			Debug.Log("PlayerScore" + PlayerScore);
			PText.GetComponent<Text> ().text = "Score:" + PlayerScore.ToString();
			new WaitForSeconds (5);
			ball.transform.position = new Vector2(50,-1);
			Instantiate (ball);
			ball.transform.position = new Vector2(5,-1);
			//ball.transform.position = new Vector2(5,-1);

			gameObject.GetComponent<Renderer> ().enabled = true;
			gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			gameObject.GetComponent<TrailRenderer> ().enabled = true;
		}
	}
}
