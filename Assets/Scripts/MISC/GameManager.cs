using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text enemyCountText;
    [SerializeField] GameObject youWinText;

    int enemyCount = 0;

    const string ENEMY_COUNT_STRING = "Enemies Left: ";

    public void AdjustEnemyCount(int amount)
    {
        enemyCount += amount;
        enemyCountText.text = ENEMY_COUNT_STRING + enemyCount.ToString();

        if(enemyCount <= 0)
        {
            youWinText.SetActive(true);
        }
    }

    public void RestartLevelButton()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void QuitButton()
    {
        Debug.Log("this dont work in the editor but it works in the build");
        Application.Quit();
    }
}

