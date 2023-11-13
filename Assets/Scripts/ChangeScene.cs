using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    SceneType GoToScene;

    public void ToNextScene()
    {
        Debug.Log("CLICKED");
        SceneLoader.ToLoadScene(GoToScene);
    }
}

