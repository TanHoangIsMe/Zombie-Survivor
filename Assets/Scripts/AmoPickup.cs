using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoPickup : MonoBehaviour
{
    [SerializeField] int amoAmount = 5;
    [SerializeField] AmoType amoType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<Amo>().IncraseAmoAmount(amoType,amoAmount);
            Destroy(gameObject);
        }
    }
}
