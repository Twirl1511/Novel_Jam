using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    [SerializeField] private List<GameObject> PizzaArray;
    public List<int> randomPieces;
    public static bool startRoll;

    public static float speed;
    public static int pieces;
    void Start()
    {
        pieces = 0;
        startRoll = false;
        speed = 8.1f;    
    }

    // Update is called once per frame
    void Update()
    {
        if (startRoll)
        {
            StartCoroutine(SwitchPieces());
        }



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
        yield return new WaitForSeconds(speed);

       
        


        for (int i = 0; i < randomPieces.Count; i++)
        {
            randomPieces[i] = Random.Range(0,8);
            for (int j = 0; j < i; j++)
            {
                if(randomPieces[j] == randomPieces[i])
                {
                    randomPieces[i] = Random.Range(0, 8);
                }
            }
        }



        for (int i = 0; i < PizzaArray.Count; i++)
        {
            PizzaArray[i].SetActive(false);
        }

        for (int i = 0; i < PizzaArray.Count; i++)
        {
            for(int j = 0; j < randomPieces.Count; j++)
            {

                if(i == randomPieces[j])
                {
                    PizzaArray[i].SetActive(false);
                }
                else
                {
                    PizzaArray[i].SetActive(true);
                }
            }

            
            
        }



        

            
        
        

    }


}
