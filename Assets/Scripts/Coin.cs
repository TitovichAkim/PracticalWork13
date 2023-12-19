using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Coin : MonoBehaviour
{
    public Bonus bonusScript;
    public void OnTriggerEnter (Collider other)
    {
        bonusScript.Trigger(other.gameObject);
    }
}
