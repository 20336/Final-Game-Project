using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextMaze : MonoBehaviour
{

    public PlayerController playerController;

    public GameObject mazeStartPos;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "EndSmiley1")
        {
            StartCoroutine("TeleportNextMaze");

        }

        if (other.transform.tag == "EndSmiley2")
        {
            StartCoroutine("EndOfMaze");
        }
    }
    IEnumerator TeleportNextMaze()
    {
        playerController.enabled = false;
        yield return new WaitForSeconds(1f);
        gameObject.transform.position = new Vector3(-65f, 50f, 45f);
        yield return new WaitForSeconds(1f);
        playerController.enabled = true;
    }

    IEnumerator EndOfMaze()
    {
        playerController.enabled = false;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
