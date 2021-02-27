using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    [SerializeField] private List<GameObject> PizzaArray;

    public static float speed;
    void Start()
    {
        speed = 8.1f;    
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var e in PizzaArray)
        {
            if (e == null)
            {
                Debug.Log("empty");
                PizzaArray.Remove(e);
            }
        }
    }

    IEnumerator SwitchPieces()
    {
        
        int number = Random.Range(0, PizzaArray.Count - 1);

            yield return new WaitForSeconds(speed);
        
        

    }


}
