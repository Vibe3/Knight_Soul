using UnityEngine;
using UnityEngine.Events;

public class passSystem : MonoBehaviour
{
    public string Target = "ÃM¤h";
    public UnityEvent Pass;
    public UnityEvent end;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == Target) Pass.Invoke();
    }

    private void Update()
    {
        if (Knight.hp <= 0)
        {
           end.Invoke();
        }
    }
}
