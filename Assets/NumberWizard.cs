using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    
    int min = 1;
    int max = 1000;
    int guess = 500;
    
    void Start()
    {
        StartGame();
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextOption();
        } 
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextOption();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Che Drago !11!1!");
            StartGame();
        }
    }
    
    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
        
        Debug.Log("welcome to number wizard");
        Debug.Log("-------------------------------------------");
        Debug.Log("pick a number, don't tell me what it is....");
        Debug.Log("-------------------------------------------");

        Debug.Log("the maximum number is " + max);
        Debug.Log("the lowest number is " + min);
        Debug.Log("-------------------------------------------");
        Debug.Log("tell me if your number is lower or higher than: " + guess);
        Debug.Log("-------------------------------------------");

        Debug.Log("Push UP arrow if it's higher // Push DOWN if it's lower // Push ENTER if it's Correct");
        
        // adding 1 to the maximum 
        max = max + 1;
    }

    void NextOption()
    {
        guess = (min + max) / 2;
        Debug.Log("Is higher or lower than..." + guess);
    }
}
