using UnityEngine;

  //���:2D ��V���b����
  //</Summary>
public class control : MonoBehaviour
{
    #region ���:���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 15000)]
    public float jump = 500;
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundoffset;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyjump = KeyCode.Space;
    public LayerMask canjumpLayer;
    #endregion

    //<summary>
    //���餸�� Rightbody 2D
    //</summary>
    private Rigidbody2D rig;
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);

        Gizmos.DrawSphere(transform.position+ checkGroundoffset, checkGroundRadius);
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    //<summary>
    // update �� 60 FPS
    // �T�w��s�ƥ� : 50 FPS
    // �B�z���z�欰
    //< /summary>
    private void FixedUpdate()
     

    {
        Move();
    }

    private void Update()
    {
        Flip();
    }



    #region ��k
    // <summary>
    // 1. ���a�O�_�������ʫ��� ���k��V�� ��A.D
    // 2. ���󲾰ʦ欰 (API)
    // </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

    }
    #endregion


    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");

        if (h< 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (h> 0)
        {
            transform.eulerAngles = Vector3.zero;
        }

    }
}
 