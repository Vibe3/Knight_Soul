using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue: MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject godialogue;
    [Header("��ܤ��e")]
    public Text textContent;
    [Header("��ܧ����ϥ�")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
       
    }

    private IEnumerator TypeEffect(string[] contents)
    {
        godialogue.SetActive(true);

        for (int j = 0; j < contents.Length; j++)
        {
            textContent.text = "";
            godialogue.SetActive(false);


            for (int i = 0; i < contents[j].Length; i++)
            {
                textContent.text += contents[j][i];
                yield return new WaitForSeconds(interval);
            }
            goTip.SetActive(true);

            while (!Input.GetKeyDown(keyDialogue))
            {
                yield return null;
            }
        }

        godialogue.SetActive(false);
    }
}
