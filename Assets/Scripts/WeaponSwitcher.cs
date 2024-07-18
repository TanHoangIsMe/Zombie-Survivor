using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon;

    // Start is called before the first frame update
    void Start()
    {
        SetActiveWeapon();
    }

    private void SetActiveWeapon()
    {
        int weaponIndex = 0;

        foreach(Transform weapon in transform)
        {
            if(weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

    void Update()
    {
        int previousWeapon = currentWeapon;

        ProcessInputKey();
        ProcessMouseWheel();

        if (previousWeapon != currentWeapon)
        {
            SetActiveWeapon();
        }
    }

    private void ProcessInputKey()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
        else
        {
            return;
        }
    }

    private void ProcessMouseWheel()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(currentWeapon >= transform.childCount - 1)
            {
                currentWeapon = 0;
            }
            else
            {
                currentWeapon++;
            }
        }
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(currentWeapon <= 0)
            {
                currentWeapon = transform.childCount - 1;
            }
            else
            {
                currentWeapon--;
            }
        }
    }
}
