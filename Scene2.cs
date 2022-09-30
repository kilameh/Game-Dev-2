using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    public void NextScene2(){
        SceneManager.LoadScene(2);
    }

    public void NextScene2_1(){
        SceneManager.LoadScene(0);
    }
}
