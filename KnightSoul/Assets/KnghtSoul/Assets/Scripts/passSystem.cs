using UnityEngine;
using UnityEngine.Events;

public class passSystem : MonoBehaviour
{
    public string Target = "�M�h";
    public UnityEvent Pass;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == Target) Pass.Invoke();
    }
}
