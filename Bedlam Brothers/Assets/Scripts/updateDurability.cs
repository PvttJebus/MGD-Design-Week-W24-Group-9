using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateDurability : MonoBehaviour
{
    // Start is called before the first frame update
    public Text durabilityText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        durabilityText.text = "Bed Durability = " + globalVariables.durability;
    }
}
