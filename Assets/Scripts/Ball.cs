using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    public Timer TimerObject;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
        if (GameObject.FindGameObjectsWithTag("Ball").Length == 1)
        {
            //Debug.Log("All balls are hit !");
            TimerObject.StopTimer();
            SceneManager.LoadScene("LevelComplete");
        }
    }
}
