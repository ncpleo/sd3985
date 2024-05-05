using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreGameSceneManager : MonoBehaviour
{
    public string nextScene;

    public void changeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
