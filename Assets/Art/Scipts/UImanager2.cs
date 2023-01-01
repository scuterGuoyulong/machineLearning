using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI�������
/// </summary>
public class UImanager2 : MonoBehaviour
{
    //����ģʽ
    public static UImanager2 instance { get; private set; }

    private void Awake()
    {
       instance = this;
    }

    public Image healthBar2;//��ɫѪ��
    /// <summary>
    /// ����Ѫ��
    /// </summary>
    /// <param name="curAmount"></param>
    /// <param name="maxAmount"></param>
    public void UpdateHealthBar(int curAmount, int maxAmount)
    {
        healthBar2.fillAmount = (float)curAmount / (float)maxAmount;
    }
}
