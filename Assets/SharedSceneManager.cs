using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName ="NewSceneManager", menuName ="New SceneManager")]
public class SharedSceneManager : ScriptableObject
{

    public string GoBackScene = "GoBackScene";
    public string MenuScene = "MenuScene";
    public string UiScene = "UIScene";
    public string SmallFire = "Level0";
    public string LargeFire = "Level1";
    public string MediumFire = "MediumFireScene";

    public List<string> ActiveScenes;

    public void LoadMenu()
    {
        ActiveScenes = new List<string>();
        ActiveScenes.Add(MenuScene);
        SceneManager.LoadSceneAsync(MenuScene, LoadSceneMode.Additive);
    }

    public void LoadLargeFire()
    {
        SceneManager.UnloadSceneAsync(MenuScene);
        SceneManager.LoadSceneAsync(UiScene, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(GoBackScene, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(LargeFire, LoadSceneMode.Additive);

        ActiveScenes.Remove(MenuScene);
        ActiveScenes.Add(LargeFire);
        ActiveScenes.Add(UiScene);
        ActiveScenes.Add(GoBackScene);
    }

    public void LoadSmallFire()
    {
        SceneManager.UnloadSceneAsync(MenuScene);
        SceneManager.LoadSceneAsync(UiScene, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(GoBackScene, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(SmallFire, LoadSceneMode.Additive);

        ActiveScenes.Remove(MenuScene);
        ActiveScenes.Add(SmallFire);
        ActiveScenes.Add(UiScene);
        ActiveScenes.Add(GoBackScene);
    }

    public void LoadMediumFire()
    {
        SceneManager.UnloadSceneAsync(MenuScene);
        SceneManager.LoadSceneAsync(UiScene, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(GoBackScene, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(MediumFire, LoadSceneMode.Additive);

        ActiveScenes.Remove(MenuScene);
        ActiveScenes.Add(MediumFire);
        ActiveScenes.Add(UiScene);
        ActiveScenes.Add(GoBackScene);
    }

    public void GoToMenu()
    {
        foreach (var scene in ActiveScenes)
            SceneManager.UnloadSceneAsync(scene);

        LoadMenu();
    }

}
