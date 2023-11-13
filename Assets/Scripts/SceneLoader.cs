using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to include this for scene switching to work

public enum SceneType
{
    //Name your scene types here and seperate them by commas. Do not they should not contain spaces. For example:
    //ExampleScene,
    //ExampleScene2,

    Scene1,
    Scene2,

};

public static class SceneLoader
{
    public static Dictionary<SceneType, string> LoadSceneDictionary { get; private set; } = new Dictionary<SceneType, string>
        {
            //add your own SceneTypes in the following format (seperate each line by commas):
            //{SceneType.NAMEOFSCENETYPE, "NAMEOFSCENE"},
            //{SceneType.NAMEOFSCENETYPE2, "NAMEOFSCENE2"},

            //the name of the scene should be what the scene files were names in the Build Settings
            {SceneType.Scene1, "360ImgTest"},
            {SceneType.Scene2, "GyroTest"},
            // {SceneType.Step1, "Step1"},
            // {SceneType.Step2, "Step2"},
            // {SceneType.Step3, "Step3"},
            // {SceneType.Step4, "Step4"},
            // {SceneType.Step5, "Step5"},
            // {SceneType.WrongTurn1, "WrongTurn1"},
        };

    public static string CurrentScene { get { return SceneManager.GetActiveScene().name; } }

    public static string PreviousSceneName;

    public static void ToLoadScene(SceneType scene)
    {
        PreviousSceneName = CurrentScene;
        SceneManager.LoadScene(LoadSceneDictionary[scene]);
    }

    public static void ToLoadScene(string scene)
    {
        PreviousSceneName = CurrentScene;
        SceneManager.LoadScene(scene);
    }
}





