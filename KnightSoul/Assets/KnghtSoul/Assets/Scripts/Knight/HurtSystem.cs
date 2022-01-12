using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HurtSystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    public string parameterDead = "Ĳ�o���`";
    [Header("���`�ƥ�")]
    public UnityEvent onDead;

    private float hpMax;
    private Animator ani;

    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }

    /*public void Hurt(float damage)
    {
        print("��q");
        hp -= damage;
        ani.SetTrigger("Ĳ�o����");
        imgHpBar.fillAmount = hp / hpMax;
        //if (hp <= 0) Dead();
    }*/

    /*private void Dead()
    {
        ani.SetTrigger(parameterDead);
        onDead.Invoke();
    }*/
}
