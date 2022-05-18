using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour
{
    [SerializeField]
    private Canvas RatCollectingScreen;
    [SerializeField]
    private TextMeshProUGUI DisplayedScore;
    [SerializeField]
    private TextMeshProUGUI FinishMaze;
    [SerializeField]
    private GameObject NotRat;
    [SerializeField]
    private AudioSource collectAudio;
    [SerializeField]
    private AudioSource notRatAudio;
    public int score;
    public static int ratsCollected;



    // Start is called before the first frame update
    void Start()
    {
        RatCollectingScreen.GetComponent<Canvas>().enabled = false;
        collectAudio = GetComponent<AudioSource>();
        notRatAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayedScore.text = "Rats: " + ratsCollected.ToString();
        AllRatsCollected();
    }

    public void AllRatsCollected()
    {
        if (ratsCollected >= 36)
        {
            FinishMaze.text = "You've Collected all the rats!\nNow find the end of the maze!";
        }
    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Rat")
        {
            RatCollectingScreen.GetComponent<Canvas>().enabled = true;
            other.gameObject.SetActive(false);
            ratsCollected++;
            collectAudio.Play();
        }
        else if (other.transform == NotRat.transform)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            NotRat.gameObject.SetActive(false);
            ratsCollected = 0;
            notRatAudio.Play();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


}
