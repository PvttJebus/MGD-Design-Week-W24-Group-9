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

    int deliveredScore = 0;
    int cleanlinessScore = 0;
    int cleanlinessPercent = 0;
    int durabilityScore = 0;
    int durabilityPercent = 0;
    int timeScore = 0;
    Timer remainingTime;
    int totalScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        deliveredScoreText.text = "Delivery Complete = " + deliveredScore.ToString() + " Points";
        cleanlinessScoreText.text = cleanlinessPercent.ToString() + "% " + "Cleanliness = " + cleanlinessScore.ToString() + " Points";
        durabilityScoreText.text = durabilityPercent.ToString() + "% " + "Bed Durability = " + durabilityScore.ToString() + " Points";
        timeScoreText.text = remainingTime.ToString() + " Remaining = " + timeScore.ToString() + " Points";
        totalScoreText.text = "Total Score = " + totalScore.ToString() + " Points";
        gameComplete = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}