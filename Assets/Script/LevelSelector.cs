using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public Text levelText;
    public static int selectedLevel;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = level.ToString();
    }

    public void OpenLevelGampang()
    {
        selectedLevel = level;
        SceneManager.LoadScene("GampangLevel " + level.ToString());
    }

    public void OpenLevelSedang()
    {
        selectedLevel = level;
        SceneManager.LoadScene("SedangLevel " + level.ToString());
    }

    public void OpenLevelAngel()
    {
        selectedLevel = level;
        SceneManager.LoadScene("AngelLevel " + level.ToString());
    }
}
