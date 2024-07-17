using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amo : MonoBehaviour
{
    [SerializeField] int amoAmount = 10;
    public int AmoAmount { get { return amoAmount; } }

    public void ReduceAmoAmount()
    {
        amoAmount--;
    }
}
