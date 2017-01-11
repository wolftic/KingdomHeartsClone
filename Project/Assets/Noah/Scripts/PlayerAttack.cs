using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	/* Zelfde knop gebruiken voor attack hierbij is het X op de PS2 controller > Zodra dit wordt ingeklikt gaat er een tijd lopen bijvoorbeeld 5 seconden >
	 Als die binnen deze tijd blijft dan komen er op een volgende attacks > valt die buiten deze 5 seconden > En wordt er daarna weer op X geklikt > Dan gaat ie waar naar 
	 de eerste Attack animatie. 
	 if(input.getkeydown(keycode.g)){
		curanim++;
		if(curanim >= 3){
		curanim = 0;
		}
		}
	*/
	float time;
	int curanim = 0;
	private int i = 0;
	void Start(){
		i = 0;
	}




	void Update(){
		if (Input.GetKeyDown (KeyCode.G)) {
			Attack ();
			time = Time.time + 5;
		}
		if (time <= Time.time) {
			i = 0;
		}
		if (i > 3) {
			i = 0;
			Debug.Log (i);
		} 
	}

	void Attack(){
		Debug.Log (i);
		i++;
	}







}
