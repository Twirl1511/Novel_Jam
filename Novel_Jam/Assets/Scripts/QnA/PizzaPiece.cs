using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaPiece : MonoBehaviour
{
    public Pizza pizzaScript;

    private void OnMouseDown()
    {
        Pizza.startRoll = true;
        Pizza.speed--;
        Pizza.pieces++;
        Debug.Log(Pizza.speed);
        pizzaScript.randomPieces.Add(0);
        gameObject.SetActive(false);
        
        
        
    }

  
}
