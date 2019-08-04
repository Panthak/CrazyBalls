using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text ScoreValue;
    // Start is called before the first frame update
    void Start()
    {
        ScoreValue.text = Timer.timerValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
