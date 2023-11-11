using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Button : MonoBehaviour
{
    public int buttonId;

    public void ClickSlot() {
       GameContainer.instance.indexClick = this.buttonId;
       Color color = new Color(1, 1, 1, 1f);
       GameContainer.instance.resetColorSoal();
       GameContainer.instance.containerSoal.GetChild(GameContainer.instance.indexClick).GetComponent<TextMeshProUGUI>().color = color;
    }

    public void SubmitAnswer(GameObject gameObject){
        string jawabanInput = gameObject.GetComponent<TMP_InputField>().text;
        if(jawabanInput.ToLower() == GameContainer.instance.listSoal[GameContainer.instance.indexClick].jawaban.ToLower())
        {
            GameContainer.instance.listJawaban[GameContainer.instance.indexClick].SetActive(true);
        }
        else
            Debug.Log("Jawaban Salah");
    }
}
