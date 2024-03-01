using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        /*if (collision = "Walls")
        {
            globalVariables.durability -= 1;
        }
        else
        {
            globalVariables.cleanliness -= 1;
        }*/


        Debug.Log("Collision!");

    }


}
