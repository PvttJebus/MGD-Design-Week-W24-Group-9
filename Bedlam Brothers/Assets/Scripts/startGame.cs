using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Mathematics;
using System;
using System.Runtime.CompilerServices;
using System.Threading;


public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    //public AudioSource audioSource;
    void Start()
    {

        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
        //scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }
    int randoNum = 0;
    int counter = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            TaskOnClick();

        }
        if (Input.GetKey(KeyCode.V))
        {
            TaskOnClick();

        }
        //
    }

    void TaskOnClick()
    {
        if (globalVariables.mapCounter == 0)
        {
            globalVariables.totalrunscore = 0;
        }
        System.Random random = new System.Random();
        Debug.Log("You have clicked the button!");
        Debug.Log(globalVariables.mapCounter);

        if (globalVariables.mapCounter >= 5 )
        {
            Debug.Log("here");
            SceneManager.LoadScene("CompletedGame", LoadSceneMode.Single);
            globalVariables.cleanliness = 100;
            globalVariables.cleanlinessPoints = 0;
            globalVariables.durability = 100;
            globalVariables.durabiityPoints = 0;
            globalVariables.deliveryScore = 0;
            globalVariables.totalScore = 0;
            globalVariables.currentGameCompleted = false;
            globalVariables.timeLeft = 0;
            globalVariables.timePoints = 0;
            globalVariables.score = 0;
            globalVariables.mapCounter = 0;
            for (int b = 1; b < globalVariables.maxLevels + 1; b++)
            {
                Debug.Log("B=" + b);
                globalVariables.levels[b] = b;
            }
            return;
        }
        



        while (true)
        {
            randoNum = random.Next(globalVariables.minLevels, globalVariables.maxLevels);
            //Debug.Log("Random Num" + randoNum);
            if (globalVariables.levels[randoNum] != 0)
            {
                //Debug.Log("Selected a random map");
                globalVariables.levels[randoNum] = 0;
                break;
            }
            if (globalVariables.mapCounter == globalVariables.maxLevels-1)
            {
                //Debug.Log("Selected all the maps!");
                break;
            }
            counter++;
            if (counter == 50)
            {
                break;
            }

        }
        globalVariables.levels[randoNum] = 0;
        globalVariables.mapCounter++;
        SceneManager.LoadScene("Level " + randoNum, LoadSceneMode.Single);
        globalVariables.cleanliness = 100;
        globalVariables.cleanlinessPoints = 0;
        globalVariables.durability = 100;
        globalVariables.durabiityPoints = 0;
        globalVariables.deliveryScore = 0;
        globalVariables.totalScore = 0;
        globalVariables.currentGameCompleted = false;
        globalVariables.timeLeft = 0;
        globalVariables.timePoints = 0;
        globalVariables.score = 0;
        
    }
}
