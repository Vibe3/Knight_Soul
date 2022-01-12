using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HurtSystem : MonoBehaviour
{
    [Header("血條")]
    public Image imgHpBar;
    [Header("血量")]
    public float hp = 100;
    public string parameterDead = "觸發死亡";
    [Header("死亡事件")]
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
        print("血量");
        hp -= damage;
        ani.SetTrigger("觸發受傷");
        imgHpBar.fillAmount = hp / hpMax;
        //if (hp <= 0) Dead();
    }*/

    /*private void Dead()
    {
        ani.SetTrigger(parameterDead);
        onDead.Invoke();
    }*/
}
