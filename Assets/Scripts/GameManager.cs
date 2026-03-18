using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioClip loseSound;
    public AudioSource audioSource;
    public GameObject gameOverText;
    public GameObject resetButton;

    public void GameOver()
    {
        GameObject[] birds = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject bird in birds)
        {
            Destroy(bird);
        }
        audioSource.PlayOneShot(loseSound);
        gameOverText.SetActive(true);
        resetButton.SetActive(true);
        Time.timeScale = 0f;       
    }
    
     public void Restart()
    {
        gameOverText.SetActive(false);
        resetButton.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
