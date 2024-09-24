
using UnityEngine;
using TMPro;
using System;

public class CCscript : MonoBehaviour
{

    Car myCar = new Car();
    
    private string makeInput;
    private string yearInput;
    public TMP_Text yearDisplay;
    public TMP_Text makeDisplay;
    public TMP_Text speedDisplay;
    private void SetSpeedText(string speedText)
    {
        
        Car currentSpeed = new Car();
        speedText = currentSpeed._currentSpeed.ToString();
        speedDisplay.text = speedText;
        Debug.Log(speedText);
    }
    private void SetYearText(string yearText)
    {
        int yearTextNum = Int32.Parse(yearText);
        if (yearTextNum >= 1886 && yearTextNum <= 2024 ) 
        {
        yearInput = yearText;
        Car year = new Car();
        year._year = yearText;
        yearDisplay.text = yearText;
        Debug.Log(year._year);
        }
        else { yearDisplay.text = (yearTextNum + " is out of manufactured car range"); }

    }
    private void SetMakeText(string makeText)
    {
        makeInput = makeText;
        Car make = new Car();
        make._make = makeText;
        makeDisplay.text = makeText;
        Debug.Log(make._make);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow)) { SetSpeedText(speedDisplay.text); }
        myCar.Accelerate();
        myCar.Decelerate();
        if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
    }
}
