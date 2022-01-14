using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Inherit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("Any");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            xButton();
        }
    }

    public virtual void xButton()
    {
        Debug.Log("XXX");
    }

    public void yButton()
    {
        Debug.Log("psych Y button");
    }
}
