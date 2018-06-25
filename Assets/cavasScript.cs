using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cavasScript : MonoBehaviour {

	public Text score;
	public Text nowItem;

	private int scoreData;
	private int nowItemData;

	public GameObject game;

	private GameControler gc;

	// Use this for initialization
	void Start () {
		gc = game.GetComponent<GameControler> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreData = gc.getScore ();
		nowItemData = gc.getNowItem ();

		textChange ();
	}

	void textChange(){
		score.text = "Score:" + scoreData.ToString ();
		nowItem.text = "nowItem:" + nowItemData.ToString ();
	}
}
