using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatCollectorTab : MonoBehaviour
{
    [SerializeField]
    private Canvas RatCollectingTab;

    // Start is called before the first frame update
    void Start()
    {
        RatCollectingTab.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TabPopUp()
    {
        RatCollectingTab.GetComponent<Canvas>().enabled = true;
    }
}
