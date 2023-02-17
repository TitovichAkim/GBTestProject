using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public void LoadScene (int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
