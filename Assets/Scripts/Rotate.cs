using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool isRotated;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        isRotated = false;
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Rotator")
        {
            //GameObject.FindGameObjectWithTag("Scene").transform.rotation = Quaternion.AngleAxis(180, Vector3.right);
            GameObject.FindGameObjectWithTag("Scene").transform.RotateAround(position, Vector3.right, 180);
            transform.RotateAround(position, Vector3.right, 180);
            if (isRotated)
            {
                isRotated = false;
            }
            else if (!isRotated)
            {
                isRotated = true;
            }
        }
    }
}
