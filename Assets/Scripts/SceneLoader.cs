using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneLoader : MonoBehaviour
{
    public void SceneUp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        BoulderVar.PrintBoulderVar(); 
    }

    public void SceneDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
