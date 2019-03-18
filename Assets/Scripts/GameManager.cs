using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject levelCompleteUI;

    public void completeLevel()
    {
        levelCompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        if (GameHasEnded==false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            //restart the game
            Invoke("Restart", restartDelay);
        }        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	
}
