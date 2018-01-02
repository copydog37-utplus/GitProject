using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	//test4
    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
}
