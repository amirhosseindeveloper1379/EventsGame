using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(int scene)
    {
        Application.LoadLevel(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
