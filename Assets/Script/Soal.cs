using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Soal", menuName = "Scriptable Object/Soal", order = 0)]
public class Soal : ScriptableObject {
    public string soal;
    public string jawaban;
    public bool isVertikal;
}
