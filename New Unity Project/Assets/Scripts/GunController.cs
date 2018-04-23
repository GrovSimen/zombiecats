using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GunController : MonoBehaviour {


	public bool isFiring;

	public ProjectileController Projectile;
	public float projectileSpeed;

	private float timeBetweenShots;
	private float shotCounter;

	public Text text;
	public int projectiles;
	public Transform firePoint;

	// Use this for initialization
	void Start ()
	{
		UpdateText();
		timeBetweenShots = 1.5f;
	}

	// Update is called once per frame
	void Update ()
	{
		if(projectiles > 0)
		{
			if (isFiring && shotCounter <= 0)
			{
				shotCounter = timeBetweenShots;
				ProjectileController newProjectile = Instantiate(Projectile, firePoint.position, firePoint.rotation) as ProjectileController;
				newProjectile.speed = projectileSpeed;
				projectiles -= 1;
			}
			else if (shotCounter >= 0)
			{
				shotCounter -= Time.deltaTime;
			}
		}

		UpdateText();
	}

	void UpdateText()
	{
		text.text = projectiles.ToString();
	}
}
