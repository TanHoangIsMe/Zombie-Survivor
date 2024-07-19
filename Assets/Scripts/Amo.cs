using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amo : MonoBehaviour
{
    [SerializeField] AmoSlot[] amoSlots;

    [System.Serializable]
    private class AmoSlot
    {
        public AmoType amoType;
        public int amoAmount;
    }

    public int GetAmoAmount(AmoType amoType) 
    {  
        return GetAmoSlot(amoType).amoAmount;
    }

    public void IncraseAmoAmount(AmoType amoType, int amoAmount) 
    {
        Debug.Log(GetAmoSlot(amoType).amoAmount + " - " + amoAmount);
        GetAmoSlot(amoType).amoAmount += amoAmount;
    }

    public void ReduceAmoAmount(AmoType amoType)
    {
        GetAmoSlot(amoType).amoAmount--;
    }

    AmoSlot GetAmoSlot(AmoType amoType) 
    {
        foreach (AmoSlot amoSlot in amoSlots)
        {
            if(amoSlot.amoType == amoType)
            {
                return amoSlot;
            }
        }
        return null;
    }
}
