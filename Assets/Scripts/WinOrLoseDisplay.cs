using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinOrLoseDisplay : MonoBehaviour
{
    [SerializeField]
    private Sprite Lose;
    [SerializeField]
    private AudioSource WinAudio;
    [SerializeField]
    private AudioSource LoseAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WinOrLose();
    }

    private void WinOrLose()
    {
        if (Collect.ratsCollected <= 0)
        {
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(460, 76);
            this.gameObject.GetComponent<Image>().sprite = Lose;
            LoseAudio.Play();
        }
        else
        {

            WinAudio.Play();
        }
    }
}
