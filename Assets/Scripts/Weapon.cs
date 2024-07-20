using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 3f;
    [SerializeField] ParticleSystem gunflash;
    [SerializeField] GameObject hitEffect;
    [SerializeField] Amo amo;
    [SerializeField] AmoType amoType;
    [SerializeField] float waitToFireTime;

    bool canShoot = true;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot == true)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        if (amo.GetAmoAmount(amoType) > 0)
        {
            canShoot = false;
            PlayGunFlash();
            ProcessRayCast();
            amo.ReduceAmoAmount(amoType);
            yield return new WaitForSeconds(waitToFireTime);
            canShoot = true;
        }
    }

    private void PlayGunFlash()
    {
        gunflash.Play();
    }

    private void ProcessRayCast()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            CreateHitImpact(hit);
            EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
            if (enemyHealth != null) enemyHealth.TakeDamage(damage);
            else return;
        }
        else return;
    }

    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact =  Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 0.1f);
    }
}
