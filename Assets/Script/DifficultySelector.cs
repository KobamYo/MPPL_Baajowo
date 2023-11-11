using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelector : MonoBehaviour
{
    public void OpenGampang()
    {
        SceneManager.LoadScene("Gampang");
    }

    public void OpenAngel()
    {
        SceneManager.LoadScene("Angel");
    }

    public void OpenFlashcard()
    {
        SceneManager.LoadScene("Flashcard");
    }

    public void OpenFlashcardDetail()
    {
        SceneManager.LoadScene("Flashcard Detail");
    }

    public void BackToDifficulty()
    {
        SceneManager.LoadScene("Difficulty");
    }
}
