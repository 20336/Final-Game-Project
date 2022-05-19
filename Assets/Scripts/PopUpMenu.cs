using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpMenu : MonoBehaviour
{
    [SerializeField]
    private AudioSource StartAudio;
    public void MazeStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartAudio.Play();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
        StartAudio.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
