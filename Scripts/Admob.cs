using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Admob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize((initStatus) =>
        {
            // SDK initialization is complete
        });
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
