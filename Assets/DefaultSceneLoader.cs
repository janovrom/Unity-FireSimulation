using UnityEngine;

public class DefaultSceneLoader : MonoBehaviour
{

    public SharedSceneManager Manager;

    void Awake()
    {
        Manager.LoadMenu();
    }

}
