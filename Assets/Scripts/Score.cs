using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float score;
    protected static float highScore;
    [SerializeField] protected Text highScoreText;
    protected Text text;



    // Start is called before the first frame update
    void Start()
    {
        if (score >= highScore)
        {
            highScore = score;
        }
        
        highScoreText.text = $"High score: {highScore.ToString()}";
        
        score = 0;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
}
