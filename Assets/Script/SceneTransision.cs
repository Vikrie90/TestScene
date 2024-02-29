using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransision : MonoBehaviour
{
    public void GoToSceneA()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToSceneB()
    {
        SceneManager.LoadScene(1);
    }
}
