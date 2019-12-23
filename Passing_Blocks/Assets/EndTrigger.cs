
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public gameManager GameManager;
    
    void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
        

    }

}
