using UnityEngine;

  //���:2D ��V���b����
  //</Summary>
public class control : MonoBehaviour
{
    #region ���:���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 15000)]
    public float jump = 300;
    #endregion

    //<summary>
    //���餸�� Rightbody 2D
    //</summary>
    private Rigidbody2D rig;

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

    #region ��k
    // <summary>
    // 1. ���a�O�_�������ʫ��� ���k��V�� ��A.D
    // 2. ���󲾰ʦ欰 (API)
    // </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("���a���k����� : " + h);
    }
    #endregion
}
