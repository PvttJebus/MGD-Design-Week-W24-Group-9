using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duribility : MonoBehaviour
{

    public int maxDuribility;
    public int currentDuribility;
    
    // Start is called before the first frame update
    void Start()
    {
        currentDuribility = maxDuribility;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
