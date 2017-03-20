using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class roll : MonoBehaviour {
	private float strength, life, charisma;
	public void OnClick(){
		

		this.strength =  Random.Range(30, 90);
		this.life = Random.Range (30, 90);
		this.charisma = Random.Range (30, 90);

		var strengthTxt = GameObject.Find ("strength").GetComponent<Text> ();
		strengthTxt.text = strength.ToString();

		var lifeTxt = GameObject.Find ("life").GetComponent<Text> ();
		lifeTxt.text = life.ToString();

		var charismaTxt = GameObject.Find ("charisma").GetComponent<Text> ();
		charismaTxt.text = charisma.ToString();	
		

	}

}
