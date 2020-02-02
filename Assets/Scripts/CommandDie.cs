using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandDie : MonoBehaviour
{
    [SerializeField]
    Text message;

    [SerializeField]
    List<CommandAsset> lineResponse = new List<CommandAsset>(0);

    void Start()
    {
        SendMessage(lineResponse[Random.Range(1, lineResponse.Count)].Message);
    }

    public void SendMessage(string myMessage)
    {
        message.text = $"{myMessage}>";
    }

}
