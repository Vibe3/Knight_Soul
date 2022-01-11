using UnityEngine;
using UnityEngine.UI;

public class Knight : MonoBehaviour
{
    int hp = 10;
    public int max_hp = 10;

    public Image blood;

    private void Start()
    {
        print("Start");
        max_hp = 10;
        hp = max_hp;
    }

    private void Update()
    {
        blood.transform.localScale = new Vector3((float)hp / (float)max_hp, blood.transform.localScale.y, blood.transform.localScale.z);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy")
        {
            hp -= 1;
        }
    }
}
