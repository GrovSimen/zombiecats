using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    private int health;
    private int currentHealth;
	// Use this for initialization
	void Start ()
    {
		health = 1;
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void HurtEnemy(int damage)
    {
        currentHealth = currentHealth - damage;
    }

}
