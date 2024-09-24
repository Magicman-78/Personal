using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Put this wherever you want it to load. For example, in Start it only happens at the beginning.
        //SceneManager.LoadScene("Level 1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This function is public so we can execute it from a UnityEvent and it will allow us to load any scene by giving it the name of the scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // These two functions are public but only execute the scene they say isntead of allowing us to load any scene 
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
