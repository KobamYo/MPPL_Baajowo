using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public void BackToGampang()
    {
        SceneManager.LoadScene("Gampang");
    }

    public void BackToAngel()
    {
        SceneManager.LoadScene("Angel");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Home Screen");
    }

    public void BackToDifficulty()
    {
        SceneManager.LoadScene("Difficulty");
    }

    public void BackToFlash()
    {
        SceneManager.LoadScene("Flashcard");
    }
}
