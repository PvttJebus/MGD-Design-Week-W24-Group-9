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
        time = 90f;
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
            SceneManager.LoadScene(1);
        }
    }

    public void IncrementTime ()
    {
        time = time - 1;
    }
}
