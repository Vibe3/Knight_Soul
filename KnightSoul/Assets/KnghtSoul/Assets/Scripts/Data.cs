using UnityEngine;

[CreateAssetMenu(menuName ="Dialogue/Data")]

public class Data : ScriptableObject
{
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] Dialogues;
}
