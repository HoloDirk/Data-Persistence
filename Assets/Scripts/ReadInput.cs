using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReadInput : MonoBehaviour
{
    
    public string input; //variable to store the InputField text
                         // Start is called before the first frame update



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s) //function to look at a string  and its parameter like s
    {
        input = s; //here we assign the variable to the string s parameter
                    //must also make empty game object add script to game object and drag it into the InputFiled game Objecton End()!!!
        Debug.Log(input); //will show in console if works properly as a saftey step
    }
}
