using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTypes : MonoBehaviour
{
    public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saterday };

    //Day yesterdayDay = Day.Thursday;
    //Day todaysDay = Day.Friday;
    //Day nextDay = Day.Saterday;
    public Day currentDay = Day.Friday;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enum Type Script is working");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Todays Day is: " + todaysDay);
            Debug.Log("I am eaing: " + ThingsToEatToday(currentDay));
        }
    }

    public string ThingsToEatToday(Day todayDay)
    {
        string thingToDoy = "Candy";

        switch (todayDay) 
        {
            case Day.Thursday:
                thingToDoy = "Hot Pot";
                break;
            case Day.Friday:
                thingToDoy = "Fried Rice";
                break;
            case Day.Saterday:
                thingToDoy = "Ramen";
                break;
            default:
                thingToDoy = "Chips";
                break;
        }   


        /*
        if (todayDay == Day.Friday)
        {
            thingToDoy = "Hot Pot";
        }
        else if (todayDay == Day.Thursday)
        {
            thingToDoy = "Fried Rice";
        }
        else if (todayDay == Day.Saterday)
        {
            thingToDoy = "Ramen";
        }
        else 
        {
            thingToDoy = "Chips";
        }
        */



        return thingToDoy;
    } 
}
