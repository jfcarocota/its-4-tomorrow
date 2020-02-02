using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Task", menuName = "Commands/Task", order = 1)]

public class CommandAsset : ScriptableObject
{
    [SerializeField, TextArea(3, 5)]
    private string message;
    [SerializeField]
    private string instruction;
    [SerializeField] 
    string fixCommand;

    public string Instruction { get => instruction; }
    public string Message { get => message; }
    public string FixCommand { get => fixCommand; }
}
