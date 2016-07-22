using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	public AudioSource racket;
	public AudioSource wall;
	public AudioSource TopBottomWall;

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
			wall.Play ();
		}

		if(col.gameObject.name == "WallRight")
		{
			wall.Play ();
		}

		if(col.gameObject.name == "RacketLeft")
		{
			racket.Play ();
		}

		if(col.gameObject.name == "RacketRight")
		{
			racket.Play ();
		}

		if(col.gameObject.name == "WallTop")
		{
			TopBottomWall.Play ();
		}

		if(col.gameObject.name == "WallBottom")
		{
			TopBottomWall.Play ();
		}
	}
}
