using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("updated_main");
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("creds_new");
    }

    public void GoToLanding()
    {
        SceneManager.LoadScene("new_start");
    }
}