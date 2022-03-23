using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for scene movement of gameObjects
using UnityEngine.UI;
using UnityEditor;

public class MenuUIHandler : MonoBehaviour
{
    //Menu Scene handler
    [SerializeField] Text InputName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame() //starts the scene in ()
    {
        SceneManager.LoadScene(1);
    }
    //This will remember the user name entered
    public void SetPlayerName()
    {
        ReadInput.Instance.input = InputName.text;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
