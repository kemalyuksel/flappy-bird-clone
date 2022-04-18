using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    private int score;
    
    public Text scoreText;
    public Button tryAgainButton;


    void Start()
    {
        tryAgainButton.onClick.AddListener(RestartGame);
    }

   
    void Update()
    {

    }


    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    


}
