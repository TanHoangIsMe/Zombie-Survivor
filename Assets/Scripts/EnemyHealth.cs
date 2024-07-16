using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoint = 100f;

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamaged");
        hitPoint -= damage;
        if(hitPoint < 0f)
        {
            Destroy(gameObject);
        }
        Debug.Log(hitPoint);
    }
}
