using UnityEngine;
using System.Collections;

public class LoadOnClickStart : MonoBehaviour {

    public void LoadScene()
    {
        Application.LoadLevel("Level1");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
