using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float time = 0.00f;
    public Text gametime;
    public float remainingTime;
    
    // Start is called before the first frame update
    void Start()
    {
        time = 20f;
        remainingTime = time;
        
        InvokeRepeating("IncrementTime", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (time > -1)
        {
            remainingTime = time;
            gametime.text = time.ToString();
        }
        if (time <= 0)
        {
            globalVariables.cleanlinessPoints = globalVariables.cleanliness * 5;
            globalVariables.durabiityPoints = globalVariables.durability * 5;
            globalVariables.totalScore = globalVariables.durabiityPoints + globalVariables.cleanlinessPoints;
            globalVariables.timeLeft = 0;
            globalVariables.timePoints = 0;
            globalVariables.deliveryScore = 0;
            SceneManager.LoadScene(4);
        }
        if (globalVariables.currentGameCompleted == true)
        {
            globalVariables.deliveryScore = 1000;
            globalVariables.timeLeft = time;
            globalVariables.timePoints = time * 100;
            globalVariables.cleanlinessPoints = globalVariables.cleanliness * 10;
            globalVariables.durabiityPoints = globalVariables.durability * 10;
            globalVariables.totalScore = globalVariables.durabiityPoints + globalVariables.cleanlinessPoints + globalVariables.timePoints + globalVariables.deliveryScore;
            globalVariables.totalrunscore = globalVariables.totalrunscore + globalVariables.totalScore;
        }
    }

    public void IncrementTime ()
    {
        time = time - 1;
    }
}
