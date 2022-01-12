using UnityEngine;



/// <summary>
/// �ĤH�欰
/// �˴��ؼЪ���O�_�b�l�ܰϰ�
/// �l�ܻP�����ؼ�
/// </summary>
public class Enemy : MonoBehaviour
{
    #region ���
    [Header("�ƾ�"), Range(1, 200)]
    public int Hp = 100;
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�ʵe�Ѽ�")]
    public string parameterWalk = "�}������";
    public string parameterAttack = "Ĳ�o����";
    [Header("�ʵe�Ѽ�")]
    public Transform target;
    [Range(1, 10)]
    public float AttackDamage = 5;
    [Header("�����Z��"), Range(0, 5)]
    public float attackDistance = 1.3f;
    [Header("�����N�o�ɶ�"), Range(0, 10)]
    public float attackCD = 2.8f;
    [Header("�ˬd�����ϰ�j�p�P�첾")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;
    public HurtSystem hurtSystem;

    private float angle = 0;

    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;
    #endregion

    #region �ƥ�

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void OnDrawGizmos()
    {
        // ���w�ϥܪ��C��
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        //ø�s�ߤ���(����,�ؤo)
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);

        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize);
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;

        ani.SetTrigger("Ĳ�o����");
    }
    private void Update()
    {
        CheckTargerInArea();
        if (Hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    #region ��k
    /// <summary>
    /// �ˬd�ؼЬO�_�b�ϰ줺
    /// </summary>
    private void CheckTargerInArea()
    {
       //2D���z.�л\����(���ߡA�ؤo�A����)
       Collider2D hit =  Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize, 0, layerTarget);

        if (hit) Move(); 


    }

    /// <summary>
    /// ����
    /// </summary>
    private void Move()
    {
        #region ����
        // �T���B��l�y�k:���L�� ? �����L�� �� true: �����L�� �� false ; 
        // �p�G �ؼЪ�X�p�� �ĤH�� X�N�N���b���� ����0
        // �p�G �ؼЪ�X�j�� �ĤH�� X�N�N���b�k�� ����180

        angle = target.position.x > transform.position.x ? 180 : 0;

        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk, true);

        float distance = Vector3.Distance(target.position, transform.position);
        //print("�P�ؼЪ��Z��: " + distance);
        #endregion
        if (Knight.hp > 0)
        {

            if (distance <= attackDistance) //�p�G�Z���p�󵥩�����Z��
            {
                rig.velocity = Vector3.zero; //����
                Attack();
            }
        }
        if (Knight.hp <=0)
        {
            ani.SetBool(parameterWalk, false);

        }
    }

    

    /// <summary>
    /// ����
    /// </summary>
    private void Attack()
    {
        if (timerAttack < attackCD)
        {
            timerAttack += Time.deltaTime;
        }
        else
        {
            ani.SetTrigger(parameterAttack);
            timerAttack = 0;
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize, 0, layerTarget);
            print("�����쪫��: " + hit.name);
            //hurtSystem.Hurt(AttackDamage);
            hit.GetComponent<Knight>().Hurt(AttackDamage);
        }
    }

    #endregion
}