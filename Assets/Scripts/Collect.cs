using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour
{
    [SerializeField]
    private Canvas ratCollectingScreen;
    [SerializeField]
    private TextMeshProUGUI displayedScore;
    [SerializeField]
    private TextMeshProUGUI finishMaze;
    [SerializeField]
    private GameObject notRat;
    public int score;
    public int ratsCollected;

    // Start is called before the first frame update
    void Start()
    {
        ratCollectingScreen.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        displayedScore.text = "Rats: " + ratsCollected.ToString();
        AllRatsCollected();
    }

    public void AllRatsCollected()
    {
        if (ratsCollected >= 36)
        {
            finishMaze.text = "You've Collected all the rats!\nNow find the end of the maze!";
        }
    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Rat")
        {
            ratCollectingScreen.GetComponent<Canvas>().enabled = true;
            other.gameObject.SetActive(false);
            ratsCollected++;
        }
        else if (other.transform == notRat.transform)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            notRat.gameObject.SetActive(false);
            ratsCollected = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


}
