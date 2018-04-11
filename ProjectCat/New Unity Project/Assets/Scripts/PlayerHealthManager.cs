using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {


	public Image currentHealthBar;
	public Text ratioText;

	public float health;
	private float currentHealth;

	public float flashLength;
	private float flashCounter;

	private Renderer rend;
	private Color storedColor;

	// Use this for initialization
	void Start () {
		currentHealth = health;
		rend = GetComponent<Renderer>();
		storedColor = rend.material.GetColor("_Color");
		UpdateHealthbar();

	}

	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0)
		{
			gameObject.SetActive(false);
		}

		if(flashCounter > 0)
		{
			flashCounter -= Time.deltaTime;
			if(flashCounter <= 0)
			{
				rend.material.SetColor("_Color", storedColor);
			}
		}
	}

	private void UpdateHealthbar()
	{
		float ratio = currentHealth / health;
		currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
		ratioText.text = (ratio * 100).ToString() + "%";
	}

	public void HurtPlayer(int damage)
	{
		currentHealth -= damage;
		flashCounter = flashLength;
		rend.material.SetColor("_Color", Color.red);
		UpdateHealthbar();
	}
}
