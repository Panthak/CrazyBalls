using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static int timerValue;
    public Text timerUI;
    public static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        timerValue = 10;
        timerUI.text = "" + timerValue;
        StartCoroutine(LoseTime());
    
    }

    public void StopTimer()
    {
        score += timerValue;
        SceneManager.LoadScene("LevelComplete");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LoseTime()
    {
        while (timerValue > 0)
        {
            yield return new WaitForSeconds(1);
            timerValue--;
            timerUI.text = ("" + timerValue);
            
        }
        SceneManager.LoadScene("TimeUp");
    }
}
