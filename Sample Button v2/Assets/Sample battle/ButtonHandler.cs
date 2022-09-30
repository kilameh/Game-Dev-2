using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ButtonHandler : MonoBehaviour
{

    //button ni jom
    public Button lowpunchbutton, highpunchbutton, lowkickbutton, highkickbutton, Specialbutton;

    //button ni joshed
    public Button lowpunch2button, highpunch2button, lowkick2button, highkick2button, Special2button; 

    public static bool taketurn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void update()
    {
        turnLogic();
    }

        public void turnLogic()
    {
        if (taketurn == true)
        {
            lowpunchbutton.interactable = true;
            highpunchbutton.interactable = true;
            lowkickbutton.interactable = true;
            highkickbutton.interactable = true;
            Specialbutton.interactable = true;

            lowpunch2button.interactable = false;
            highpunch2button.interactable = false;
            lowkick2button.interactable = false;
            highkick2button.interactable = false;
            Special2button.interactable = false;
        }

        else if (taketurn == false)
        {
            lowpunchbutton.interactable = false;
            highpunchbutton.interactable = false;
            lowkickbutton.interactable = false;
            highkickbutton.interactable = false;
            Specialbutton.interactable = false;

            lowpunch2button.interactable = true;
            highpunch2button.interactable = true;
            lowkick2button.interactable = true;
            highkick2button.interactable = true;
            Special2button.interactable = true;
        }
    }
}
