using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
   public void ButtonPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
