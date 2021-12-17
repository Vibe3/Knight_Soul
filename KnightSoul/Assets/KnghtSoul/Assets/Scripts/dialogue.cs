using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue: MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject godialogue;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話完成圖示")]
    public GameObject goTip;
    [Header("對話按鍵")]
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
