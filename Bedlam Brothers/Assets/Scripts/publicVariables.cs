using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class publicVariables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int b = 1; b < globalVariables.maxLevels+1; b++)
        {
            Debug.Log("B="+ b);
            globalVariables.levels[b] = b;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public static class globalVariables
{
    public static int minLevels = 1;
    public static int maxLevels = 6;
    public static float score = 0;
    public static bool currentGameCompleted = false;
    public static float timeLeft = 0;
    public static float timePoints = 0;
    public static float deliveryScore = 0;
    public static float cleanliness = 100;
    public static float cleanlinessPoints = 0;
    public static float durability = 100;
    public static float durabiityPoints = 0;
    public static float totalScore = 0;
    public static float totalrunscore = 0;
    public static int[] levels = new int[globalVariables.maxLevels+1];
    public static int mapCounter = 0;
    public static double footCounter = 0;
    public static bool playSound = false;
    



}
