using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{
    public InputField milesInput;
    public float miles;
    public Text stats;
    public InputField dateInput;
    public Image map;
    public Image mapDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartRunning()
    {
        Instantiate(map);   
        Instantiate(mapDistance);
        if (string.Equals(milesInput.text , "safeway", StringComparison.InvariantCultureIgnoreCase))
        {
            miles = 9;
        }
        else if (string.Equals(milesInput.text , "parking", StringComparison.InvariantCultureIgnoreCase))
        {
            miles = 4.6f;
        }
        print(miles);
        stats.text = $"Today you helped the world reduce {miles * 411} grams of CO2 by biking.\r\n";
    }
}
