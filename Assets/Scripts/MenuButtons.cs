using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuButtons : MonoBehaviour
{
    public void StartNew(){
        SceneManager.LoadScene(1);
    }

    public void GoToMenu(){
        SceneManager.LoadScene(0);
    }

    public void Exit(){
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
