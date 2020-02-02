using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandDie : MonoBehaviour
{
    [SerializeField]
    Text message;
    [SerializeField]
    Text options;

    [SerializeField]
    List<CommandAsset> lineResponse = new List<CommandAsset>(0);

    List<CommandAsset> responsesClone = new List<CommandAsset>(0);
    string commandSolution;

    [SerializeField]
    Button btnFix;
    [SerializeField]
    Text commandTyped;

    [SerializeField]
    Hamma hamma;

    [SerializeField]
    int yourDamage;
    [SerializeField]
    GameObject firedText;
    [SerializeField]
    int health;
    [SerializeField]
    Text txtAfore;
    
    void Start()
    {
        ResetConsole();
    }

    void ResetConsole()
    {
        responsesClone.Clear();
        responsesClone = lineResponse;
        int selected = Random.Range(0, lineResponse.Count - 1);
        responsesClone.RemoveAt(selected);
        commandSolution = lineResponse[selected].FixCommand;
        SendMessage(lineResponse[selected].Message);
        PopulateOptions();

        btnFix.onClick.AddListener(TryFix);
    }

    public void SendMessage(string myMessage)
    {
        message.text = $"{myMessage}>";
    }

    void PopulateOptions()
    {
        for(int i = 0; i < 2; i++)
        {
            options.text += $"\n○ {responsesClone[i].FixCommand}";
        }
        options.text += $"\n○ {commandSolution}";
    }

    void TryFix()
    {
        if(CommandMatch)
        {
            hamma.GettingDamage(yourDamage);
            ResetConsole();
            //Shutdown();
        }
        else
        {
            //hamma attack
            GettingDamage(hamma.Damage);
            Application.Quit();
        }
    }

    bool CommandMatch
    {
        get => commandSolution.CompareTo(commandTyped.text) == 0;
    }

    //ME PASÉ DE VG XD
    void Shutdown()
    {
        System.Diagnostics.Process.Start("osascript" + "Kiosk1.Contents.Data.StreamingAssets" + "/ShutDownMac.scpt");
        System.Diagnostics.Process.Start("osascript Kiosk1/Contents/Data/StreamingAssets/ShutDownMac.scpt");
    }

    public void GettingDamage(int dmg)
    {
        health -= health - dmg < 0 ? 0 : dmg;
        txtAfore.text = $"AFORE: <color=magenta>{health}%</color>";
        firedText.SetActive(health == 0);
    }
}
