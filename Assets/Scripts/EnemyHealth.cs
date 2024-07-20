using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoint = 100f;
    bool isDead = false;
    public bool IsDead {  get { return isDead; } }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamaged");
        hitPoint -= damage;
        if(hitPoint < 0f)
        {
            if(isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
        }
    }
}
