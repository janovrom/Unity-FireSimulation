using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName ="New Scene Level", menuName ="Scene Level")]
public class SceneLevel : ScriptableObject
{

    public List<GameScene> Scenes;

    public void LoadOver(SceneLevel sceneLevel)
    {
        if (sceneLevel is null)
        {
            Load();
            return;
        }

        foreach (GameScene gameScene in sceneLevel.Scenes)
        {
            // Don't remove shared scene
            if (!Scenes.Contains(gameScene))
                SceneManager.UnloadSceneAsync(gameScene.SceneName);
        }

        foreach (GameScene gameScene in Scenes)
        {
            if (!sceneLevel.Scenes.Contains(gameScene))
                SceneManager.LoadSceneAsync(gameScene.SceneName, LoadSceneMode.Additive);
        }
    }

    public void UnloadAll()
    {
        foreach (GameScene gameScene in Scenes)
        {
            SceneManager.UnloadSceneAsync(gameScene.SceneName);
        }
    }

    public void Load()
    {
        foreach (GameScene gameScene in Scenes)
        {
            SceneManager.LoadSceneAsync(gameScene.SceneName, LoadSceneMode.Additive);
        }
    }

}
