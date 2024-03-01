using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateCleanliness : MonoBehaviour
{
    // Start is called before the first frame update
    public Text cleanlinessText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cleanlinessText.text = "Cleanliness = " + globalVariables.cleanliness;
    }
}
