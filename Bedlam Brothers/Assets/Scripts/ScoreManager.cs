using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public bool gameComplete = false;

   Timer Timer = new Timer();
    public Text deliveredScoreText;
    public Text cleanlinessScoreText;
    public Text cleanlinessPercentText;
    public Text durabilityScoreText;
    public Text durabilityPercentText;
    public Text timeScoreText;
    public Text remainingTimeText;
    public Text totalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        deliveredScoreText.text = "Delivery Complete = " + globalVariables.deliveryScore.ToString() + " Points";
        cleanlinessScoreText.text = globalVariables.cleanliness.ToString() + "% " + "Cleanliness = " + globalVariables.cleanlinessPoints.ToString() + " Points";
        durabilityScoreText.text = globalVariables.durability.ToString() + "% " + "Bed Durability = " + globalVariables.durabiityPoints.ToString() + " Points";
        timeScoreText.text = globalVariables.timeLeft.ToString() + " Seconds Remaining = " + globalVariables.timePoints.ToString() + " Points";
        totalScoreText.text = "Total Score = " + globalVariables.totalScore.ToString() + " Points";
        gameComplete = true;
    }
}
