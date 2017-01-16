using UnityEngine;

namespace Noah.Scripts
{
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
        private float _time;

        private int _curanim = 0;
        private int _i;


        private void Start(){
            _i = 0;
        }


        private void Update(){
            if (Input.GetKeyDown (KeyCode.G)) {
                Attack ();
                _time = Time.time + 5;
            }
            if (_time <= Time.time) {
                _i = 0;
            }
            if (_i <= 3) return;
            _i = 0;
            Debug.Log (_i);
        }

        private void Attack(){
            Debug.Log (_i);
            _i++;
        }
    }
}
