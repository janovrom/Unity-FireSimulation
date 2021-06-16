using UnityEngine;

public class DefaultSceneLoader : MonoBehaviour
{

    public SceneAssetManager SceneAssetManager;

    void Start()
    {
        SceneAssetManager.LoadMenu();
    }

}
