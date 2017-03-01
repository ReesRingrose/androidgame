using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preloader : MonoBehaviour {

    private CanvasGroup fadeGroup;
    private float loadTime;
    private float minimunLogoTime = 3.0f; //minimun time in the scene

   private void start()
    {
        //grab the canvas group
        fadeGroup = FindObjectOfType<CanvasGroup>();

        fadeGroup.alpha = 1;

        if (Time.time < minimunLogoTime)
            loadTime = minimunLogoTime;
        else
            loadTime = Time.time;
    }

    private void update()
    {
        if (Time.time < minimunLogoTime)
        {
            fadeGroup.alpha = 1 - Time.time;
        }
         
        if(Time.time > minimunLogoTime && loadTime != 0 )
            {
            fadeGroup.alpha = Time.time - minimunLogoTime;
            if (fadeGroup.alpha >=1)
            {
                Debug.Log("Change the scene");
            }

        }
    }
}
