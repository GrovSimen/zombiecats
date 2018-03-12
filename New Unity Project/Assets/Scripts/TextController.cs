using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

	private TextMesh textObject;
	private int wPressed, aPressed, sPressed, dPressed, mouseClick, qPressed, state;

	void Start()
	{
		textObject = GameObject.Find ("tut_text").GetComponent<TextMesh> ();
		textObject.text = "For å bevege seg, trykk:\n'WASD'\nsnu deg med datamusen";
		state = 0;
	}

	void Update()
	{
		//Press the space key to change the Text message
		incrementKeyPressed();
		changeText ();
	}

	private void changeText(){
		if ((wPressed > 5) && (aPressed > 5) && (sPressed > 5) && (dPressed > 5) && (state == 0)) {
			textObject.text = "Trykk q for å grave\nom du er i nærheten av eit hull";
			state = 1;
		} else if ((qPressed > 5) && (state == 1)) {
			textObject.text = "Trykk på musen for å skyte vannballonger";
			state = 2;
		} else if ((mouseClick > 8) && (state == 2)) {
			textObject.text = "Ha det morro!";
			state = 3;
		} else if (mouseClick > 35 && (state == 3)) {
			textObject.text = "";
		}
	}

	private void incrementKeyPressed(){
		if((wPressed < 7) || (aPressed < 7) || (sPressed < 7) || (dPressed < 7)){
			if (Input.GetKeyUp (KeyCode.W)) {
				wPressed++;
			} else if (Input.GetKeyUp (KeyCode.A)) {
				aPressed++;
			} else if (Input.GetKeyUp (KeyCode.S)) {
				sPressed++;
			} else if (Input.GetKeyUp (KeyCode.D)) {
				dPressed++;
			}
		}

		if (mouseClick < 30) {
			if(Input.GetMouseButtonUp(0)){
				mouseClick++;
			}
		}

		if ( qPressed < 7){					
			if(Input.GetKeyUp(KeyCode.Q)){
				qPressed++;
			}
		}

	}
}
