using UnityEngine;

  //控制器:2D 橫向卷軸版本
  //</Summary>
public class control : MonoBehaviour
{
    #region 欄位:公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 500;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundoffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyjump = KeyCode.Space;
    public LayerMask canjumpLayer;
    #endregion

    //<summary>
    //剛體元件 Rightbody 2D
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
    // update 約 60 FPS
    // 固定更新事件 : 50 FPS
    // 處理物理行為
    //< /summary>
    private void FixedUpdate()
     

    {
        Move();
    }

    private void Update()
    {
        Flip();
    }



    #region 方法
    // <summary>
    // 1. 玩家是否有按移動按鍵 左右方向鍵 或A.D
    // 2. 物件移動行為 (API)
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
 