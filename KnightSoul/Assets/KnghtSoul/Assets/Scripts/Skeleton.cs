using UnityEngine;

public class Skeleton : MonoBehaviour
{
    //�u�\��q,�ˮ`..���ƾ�

    #region
    
    [Header("�ƾ�"), Range(1, 200)]
    public int Hp = 100;
    [Range(1, 10)]
    public int Attack = 5;
    [Range(1, 10)]
    public int Armor = 5;
    [Range(1, 10)]
    public int MoveSpeed = 5;
    [Header("�O�_�������a")]
    public bool Attackplayer = true;
    
    #endregion

    /// <summary>
    /// �ĤH�欰
    /// �˴��ؼЪ���O�_�b�l�ܰϰ�
    /// �l�ܻP�����ؼ�
    /// </summary>
}
