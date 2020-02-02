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

    void Start()
    {
        responsesClone = lineResponse;
        int selected = Random.Range(0, lineResponse.Count - 1);
        responsesClone.RemoveAt(selected);
        SendMessage(lineResponse[selected].Message);
        PopulateOptions();
    }

    public void SendMessage(string myMessage)
    {
        message.text = $"{myMessage}>";
    }

    void PopulateOptions()
    {
        for(int i = 0; i < 3; i++)
        {
            options.text += $"\n○ {responsesClone[i].FixCommand}";
        }
    }
}
