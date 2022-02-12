using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderMain : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(2);
    }
}