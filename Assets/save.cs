using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour {

	public gameControl gc;

	public void Save(){
		PlayerPrefs.SetFloat("Cash", gc.cash);
		PlayerPrefs.SetFloat("Fish", gc.fish);
	}

	public void Load(){
		gc.cash = PlayerPrefs.GetFloat("Cash");
		gc.fish = PlayerPrefs.GetFloat("Fish");

	}

}
