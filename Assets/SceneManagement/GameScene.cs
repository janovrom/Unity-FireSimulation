#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[CreateAssetMenu(fileName ="New SceneAsset", menuName ="Scene asset")]
public class GameScene : ScriptableObject
{

#if UNITY_EDITOR
    [SerializeField]
    private SceneAsset _sceneAsset;
#endif

    [SerializeField]
    private string _sceneName;

    public string SceneName => _sceneName;

    private void OnValidate()
    {
#if UNITY_EDITOR
        if (!(_sceneAsset is null))
        {
            _sceneName = _sceneAsset.name;
        }
        else
        {
            _sceneName = "Invalid scene";
        }
#endif
    }

}
