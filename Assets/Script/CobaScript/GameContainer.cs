using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameContainer : MonoBehaviour
{
    public static GameContainer instance;
    public List<Soal> listSoal;
    private List<Soal> listSoalVertikal = new List<Soal>();
    public List<GameObject> listJawaban;
    public int indexClick;
    private List<Soal> listSoalHorizontal = new List<Soal>();
    public List<GameObject> huruf;
    public GameObject templateSoal;
    public Transform containerSoal;
    // Start is called before the first frame update
    public void Awake() {
        instance = this;
    }
    
    void Start()
    {
        indexClick = 0;
        instatiatie();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void instatiatie(){
        int number = 1;
        foreach (Soal soal in listSoal)
        {
            GameObject gameObject = Instantiate(templateSoal, containerSoal);
            gameObject.GetComponent<TextMeshProUGUI>().text = number.ToString() + ". " + soal.soal;
            number++;
        }
    }

    public void resetColorSoal(){
        Color color = new Color(0, 0, 0, 1f);
        for (int i = 0; i < listSoal.Count; i++)
            containerSoal.GetChild(i).GetComponent<TextMeshProUGUI>().color = color;
    }
}
