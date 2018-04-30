using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {


    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

   



