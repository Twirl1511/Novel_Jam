using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSlice : MonoBehaviour
{
    public Pizza PizzaScript;
    private void OnMouseDown()
    {
        PizzaScript.EatPizza();
        gameObject.SetActive(false);
    }
}
