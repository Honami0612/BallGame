using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemscript : MonoBehaviour {

	private GameObject game;

	// Use this for initialization
	void Start () {
		game = GameObject.Find ("GameControler");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c){
		if(c.tag=="Player"){
			game.GetComponent<GameControler> ().addScore ();
			game.GetComponent<GameControler> ().subItem ();
			Destroy(this.gameObject);
 		}
	}
}
