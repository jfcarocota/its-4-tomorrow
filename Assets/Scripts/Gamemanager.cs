using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    [SerializeField]
    CommandDie commandDie;

    public static Gamemanager instance; 

    void AWake()
    {
        instance = this;
    }


}
