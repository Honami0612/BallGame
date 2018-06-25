using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour {


	public GameObject itemData;
	public GameObject itemData1;
	private List<GameObject> item;


	private int sumscore;
	private int score1;
	private int maxItem;
	private int nowItem;

	private float x;
	// Use this for initialization
	void Start () {
		score1 = 0;
		maxItem = 5;
		nowItem = maxItem;
		x = -6;

		item = new List<GameObject> ();

		for (int i = 0; i < maxItem; i++) {
			x = -6.0f + (i *3.0f);
			item.Add (Instantiate (itemData, new Vector3 (x, 1.0f, Random.Range (-9.0f, 9.0f)), Quaternion.identity));
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (nowItem == 0) {
			SceneManager.LoadScene("clear");
		}
	}
	public void addScore(){
		score1 += 100;
	}
	public void subScore(){
		score1 -= 30;
	}

	public void subItem(){
		nowItem--;
	}
	public int getScore(){
		return score1;
	}
	public int getNowItem(){
		return nowItem;
	}
}
