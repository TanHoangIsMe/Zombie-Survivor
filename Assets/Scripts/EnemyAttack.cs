using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] public float damage = 40f;

    PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
       playerHealth = FindObjectOfType<PlayerHealth>(); 
    }

    void AttackHitEvent()
    {
        if (playerHealth != null)
        {
            playerHealth.Attacked(damage);
            GetComponent<DisplayDamage>().TurnOnSplashCanvas();
        }
    }
}
