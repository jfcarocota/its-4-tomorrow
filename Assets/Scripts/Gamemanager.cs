using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    [SerializeField]
    CommandDie commandDie;

    [SerializeField]
    GameObject winText;
    
    public static Gamemanager instance;

    public GameObject WinText { get => winText; }

    void AWake()
    {
        instance = this;
    }
}
