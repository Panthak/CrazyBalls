using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    //public Text TotalScore;
    // Start is called before the first frame update
    void Start()
    {
        //TotalScore.text = Timer.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start");
    }

    public void Quit()
    {
        Application.Quit();
    }
  
}
