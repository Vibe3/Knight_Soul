using UnityEngine;
//澄 2021/11/7第一次更新

public class Skeleton : MonoBehaviour
{
    //骷髏血量,傷害..等數據

    #region
    
    [Header("數據"), Range(1, 200)]
    public int Hp = 100;
    [Range(1, 10)]
    public int Attack = 5;
    [Range(1, 10)]
    public int Armor = 5;
    [Range(1, 10)]
    public int MoveSpeed = 5;
    [Header("是否攻擊玩家")]
    public bool Attackplayer = true;
    
    #endregion

}
