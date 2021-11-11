using UnityEngine;
//澄 2021/11/7第一次更新

public class Knight : MonoBehaviour
{
    //騎士血量,傷害..等數據

    #region
    
    [Header("數據") , Range( 1, 200) ]
    public int Hp = 100;
    [Range(1 , 10)]
    public int Attack = 5;
    [Range(1, 10)]
    public int Armor = 5;
    [Range(1, 10)]
    public int MoveSpeed = 5;
    [Header("是否能防禦")]
    public bool Defense = false;

    #endregion

    //鍵盤操作

    #region

    [Header("操作按鍵")]
    public KeyCode keycode;
    public KeyCode keyCodeAttack = KeyCode.Mouse0;
    public KeyCode keyCodeMoveLeft = KeyCode.D;
    public KeyCode keyCodeMoveRight = KeyCode.A;
    public KeyCode keyCodeJump = KeyCode.Space;
    
    #endregion

}
