using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hamma : MonoBehaviour
{
    [SerializeField]
    int health;
    [SerializeField]
    int damage;
    [SerializeField]
    TextMeshProUGUI  txtHealth;

    public int Health { get => health; }
    public int Damage { get => damage; }

    public void GettingDamage(int dmg)
    {
        health -= health - dmg < 0 ? 0 : dmg;
        txtHealth.text = $"Vida: <color=orange>{health}</color>";
    }
}
