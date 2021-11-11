using UnityEngine;

public class Goblin : MonoBehaviour
{
    //哥布林血量,傷害..等數據

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
