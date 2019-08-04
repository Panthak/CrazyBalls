using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public static int i = 0;
    public static int TotalLevels = 4;
    public void LoadNextLevel()
    {
        if(i < TotalLevels)
        {
            SceneManager.LoadScene("Level_" + (++i));
        }
        else
        {
            i = 0;
            SceneManager.LoadScene("Credits");
        }
        
    }
    public void LoadCurrentLevel()
    {
       
        SceneManager.LoadScene("Level_" + i);

    }
}
