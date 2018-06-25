using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControler : MonoBehaviour {

	public GameObject over;
	public float speed = 10;
	private float x;
	private float z;

	private Rigidbody rigidbody;

	public GameObject game;

	private GameControler gc;

	// Use this for initialization
	void Start () {
		rigidbody = this.gameObject.GetComponent<Rigidbody> ();
		gc = game.GetComponent<GameControler> ();
	}
	
	// Update is called once per frame
	void Update () {
		x = Input.GetAxis ("Horizontal");
		z = Input.GetAxis ("Vertical");

			rigidbody.AddForce (x * speed, 0, z * speed);
		}


	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "wall") {
			Debug.Log ("wall");
			gc.subScore ();
		}

	}
	void OnTriggerEnter(Collider co){
		Debug.Log ("tag:" + co.tag);
		if (co.tag == "Underfloor") {
			SceneManager.LoadScene("gameover");
		}
	}

}
