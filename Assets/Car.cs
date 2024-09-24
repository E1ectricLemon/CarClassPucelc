
using UnityEngine;
//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Christian Pucel
//Section: SGD.213.2101
//Instructor: Ven Lewis
//Date: 09/24/2024
/////////////////////////////////////////////


public class Car
{
    private string year;
    private string make;
    private int currentSpeed = 0;
    private int maxSpeed = 100;



    public string _year
    {
        get{ return year; }
        set { year = value; }
    }
    public string _make
    {
        get { return make; }
        set { make = value; }
    }

    public int _currentSpeed
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
    }

    public void Accelerate()
    {
        if(currentSpeed < maxSpeed && currentSpeed >= 0)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                currentSpeed += 10;
                Debug.Log(currentSpeed);
            }
        }
    }

    public void Decelerate()
    {
        if (currentSpeed > 0)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                currentSpeed -= 10;
                Debug.Log(currentSpeed);
            }
        }
    }

}
