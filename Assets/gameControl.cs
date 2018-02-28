using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameControl : MonoBehaviour {

	public Text cashText;
	public Text fishText;
	public float cash;
	public float fish;

	// Use this for initialization
	void Start () {
		cash = 100;
		cashText.text = "Cash: $" + cash;
		fishText.text = "Fish: " + fish;
	}
	
	// Update is called once per frame
	void Update () {
		
		cashText.text = "Cash: $" + cash;
		fishText.text = "Fish: " + fish;
	}

	public void buyFish(){
		if(cash >= 10){
			cash -= 10;
			fish ++;
		}

	}
}
