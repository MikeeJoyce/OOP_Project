using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {


    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
		if (Input.GetMouseButtonDown (1)) 
		{
			Application.Quit ();
		}
    }
}

   



