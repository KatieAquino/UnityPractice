using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 0;
        string playerName = "Bob";
        float jumpForce = 5.82f;
        bool gameOver = false;
        float myNumber = 5.0f;
        myNumber += 15.2f;
        myNumber *= 3.0f;
        myNumber--;
        myNumber++;

        float b = 2.0f;
        myNumber += b;
        float c = b * 2.0f;

        Debug.Log(myNumber);

        int numA = 10;
        int numB = 15;

        if(numA < numB)
        {
            Debug.Log("numA is less than numB");

            if(numA == 5 && numB == 6)
            {
                Debug.Log("numA is 5 and numb is 6");
            }

            if(numA > 5 || numB > 10)
            {
                Debug.Log("Either numA is greather than 5 or numB is greater than 10.");
            }
        }
        else if(numA > numB)
        {
            Debug.Log("numA is greater than numB");
        }
        else
        {
            Debug.Log("numA is equal to numB");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
