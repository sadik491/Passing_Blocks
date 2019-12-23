using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject CompleteUI;
    public playerMove stop;
    
    
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }

    }

    public void CompleteLevel()
    {
        CompleteUI.SetActive(true);
        stop.forwardForce = 0f;
        stop.sideForce = 0f;
        
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
}
