using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaPiece : MonoBehaviour
{
    private void OnMouseDown()
    {
        Pizza.speed--;
        Debug.Log(Pizza.speed);
        Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("pizzaPlace"))
        {

        }
    }
}
