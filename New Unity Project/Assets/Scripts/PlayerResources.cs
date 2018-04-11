// controls player resources

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResources : MonoBehaviour {

	private int keys;
	private int coins;
	private int bones;
	private int goldenBones;

	// Use this for initialization
	void Start () {
		keys = 0;
		coins = Data.Coins;
		bones = Data.Bones;
		goldenBones = Data.GoldenBones;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void addKey(){
		keys++;
	}

	public void useKey(){
		keys--;
	}

	private void addCoins(int amountOfCoins){
		coins += amountOfCoins;
		Data.Coins += amountOfCoins;
	}

	/*
	public void useCoins(){
		// no function to use coins on
	}
	*/

	private void addBone(){
		bones++;
		Data.Bones++;
	}

	/*
	public void useBone(){
		// no function to use bones on
	}
	*/

	public int getBones(){
		return bones;
	}

	public int getCoins(){
		return coins;
	}

	public int getKeys(){
		return keys;
	}

	public void giveResource(string resource){
		if (resource == "key") {
			addKey ();
			print ("keys: " + keys);
		} else if (resource == "coin") {
			addCoins (Mathf.RoundToInt (Random.value * 20) + 20);
			print ("coins: " + coins);
		} else if (resource == "bone") {
			addBone ();
			print ("bones: " + bones);
		} else if (resource == "golden bone") {
			goldenBones++;
			Data.GoldenBones++;
		}
	}

	public int getGoldenBones(){
		return goldenBones;
	}
}
