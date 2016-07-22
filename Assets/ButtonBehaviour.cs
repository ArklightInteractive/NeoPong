using UnityEngine;
using System.Collections;

public class ButtonBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Singleplayer() {
		Application.LoadLevel("Singleplayer");
	}

	public void MPLocal() {
		Application.LoadLevel("MPLocal");
	}

	public void MainMenu() {
		Application.LoadLevel("MainMenu");
	}

}
