using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {
    public string skyview;
    /*how to make a function
     * you need to type which type (void....or other)
     * then have a {to start the argument
     */
    private void Update()
    {
        Weather(skyview);
        
    }
    void Weather (string weatherTemp) {
        

        if (weatherTemp == "sunny" || weatherTemp == "Sunny"|| weatherTemp == "Sun" || weatherTemp == "sun" || weatherTemp == "Bright")
        {
            print("The sun is shining!");
        }
        else if(weatherTemp=="Raining"|| weatherTemp == "raining" || weatherTemp == "wet" || weatherTemp == "Wet")
        {
            print("Break out your Umbrella!");
        }
        else if (weatherTemp == "Snowing" || weatherTemp == "snowing" || weatherTemp == "Cold" || weatherTemp == "ice")
        {
            print("Baby it's cold, outside");
        }
        else if (weatherTemp == "Windy" || weatherTemp == "windy" || weatherTemp == "blowing")
        {
            print("WindyCITY!");
        }
        else if (weatherTemp == "Cloudy" || weatherTemp == "cloudy" || weatherTemp == "covered")
        {
            print("Cloudy skies up ahead");
        }
        else
        {
            print("so sorry sir, i don't understand the input of " + weatherTemp+" type help for all options");
        }


    }




}
