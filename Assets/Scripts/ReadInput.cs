using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    //static class for saving data stream of current user aka singleton
    public static ReadInput Instance;
    public string input; //variable to store the InputField text of player
                         // Start is called before the first frame update
    public int Score;

    private void Awake() //Awake method
    {
        if (Instance != null) //conditional statement to check whether or not Instance is null
        {
            Destroy(gameObject); //first time that you launch the Menu scene, no MainManager will have filled the Instance variable. This means it will be null, so the condition will not be met, and the script will continue
            return;
        }

        Instance = this; // if you load the Menu scene again later, there will already be one MainManager in existence, so Instance will not be null. In this case, the condition is met: the extra MainManager is destroyed and the script exits there.
        DontDestroyOnLoad(gameObject); //this is a "singleton"
    }

    public void ReadStringInput(string s) //takes the stream of data from InputField aka ReadInput that has game object InputText with script ReadInput
    {
        input = s;
    }
}
