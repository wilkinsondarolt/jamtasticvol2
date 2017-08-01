using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public static GameController instance = null;
    public bool Sounds = true;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void EndGame()
    {

    }
}
