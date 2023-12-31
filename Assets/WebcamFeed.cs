using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamDualEyed : MonoBehaviour
{

    public GameObject plane;
    //Second Camera Added by Meg
  
    public int cameraNumber = 3;

    private WebCamTexture webCamTexture;
    private WebCamDevice webCamDevice;

    void Start()
    {
        // Checks how many and which cameras are available on the device
        for (int cameraIndex = 0; cameraIndex < WebCamTexture.devices.Length; cameraIndex++)
        {
            Debug.Log("WebCamDevice " + cameraIndex + " name " + WebCamTexture.devices[cameraIndex].name);
        }

        if (WebCamTexture.devices.Length > cameraNumber)
        {
            Debug.Log("--> Camera num is " + cameraNumber);
            webCamDevice = WebCamTexture.devices[cameraNumber];
            webCamTexture = new WebCamTexture(webCamDevice.name, 3840, 1920);
            plane.GetComponent<Renderer>().material.mainTexture = webCamTexture;
           
            webCamTexture.Play();
        }
        else
        {
            Debug.Log("no camera");
        }
    }
}