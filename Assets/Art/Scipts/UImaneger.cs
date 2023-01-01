using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI�������
/// </summary>
public class UImaneger : MonoBehaviour
{
    //����ģʽ
    public static UImaneger instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public Image healthBar;//��ɫѪ��
    /// <summary>
    /// ����Ѫ��
    /// </summary>
    /// <param name="curAmount"></param>
    /// <param name="maxAmount"></param>
    public void UpdateHealthBar(int curAmount,int maxAmount)
    {
        healthBar.fillAmount = (float)curAmount / (float)maxAmount;
    }
}
