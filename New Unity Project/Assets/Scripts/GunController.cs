using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {


    public bool isFiring;

    public ProjectileController Projectile;
    public float projectileSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(isFiring && shotCounter <= 0)
        {
            shotCounter = timeBetweenShots;
            ProjectileController newProjectile = Instantiate(Projectile, firePoint.position, firePoint.rotation) as ProjectileController;
            newProjectile.speed = projectileSpeed;
        } else
        {
        shotCounter -= Time.deltaTime;
        }
	}
}
