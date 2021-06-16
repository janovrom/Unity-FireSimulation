using UnityEngine;

[CreateAssetMenu(fileName ="SceneAssetManager", menuName ="New Scene Asset Manager")]
public class SceneAssetManager : ScriptableObject
{

    public SceneLevel MenuLevel;
    public SceneLevel SmallFireLevel;
    public SceneLevel MediumFireLevel;
    public SceneLevel LargeFireLevel;

    private SceneLevel _activeLevel = null;

    private void OnEnable()
    {
        _activeLevel = null;
    }

    public void LoadMenu()
    {
        MenuLevel.LoadOver(_activeLevel);
        _activeLevel = MenuLevel;
    }

    public void LoadLargeFire()
    {
        LargeFireLevel.LoadOver(_activeLevel);
        _activeLevel = LargeFireLevel;
    }

    public void LoadSmallFire()
    {
        SmallFireLevel.LoadOver(_activeLevel);
        _activeLevel = SmallFireLevel;
    }

    public void LoadMediumFire()
    {
        MediumFireLevel.LoadOver(_activeLevel);
        _activeLevel = MediumFireLevel;
    }

}
