using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia; 


public class VBtnFn : MonoBehaviour
{
    public GameObject vbBtnObj;
    public GameObject obj1;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Pressed");
        obj1.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
        obj1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

