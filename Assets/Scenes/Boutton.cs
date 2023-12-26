using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boutton : MonoBehaviour
{
    public string scene;
    public string next;
    public static int ballbool = 1;
    public static int a = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void replay()
    {
        SceneManager.LoadScene(scene);
        ballbool = 1;
        a = 1;
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
        ballbool = 1;
        a = 1;
    }
    public void nexts()
    {
        SceneManager.LoadScene(next);
        ballbool = 1;
        a = 1;
    }
    public void exit()
    {
        ballbool = 1;
        a = 1;
        Application.Quit();

        
    }
}
