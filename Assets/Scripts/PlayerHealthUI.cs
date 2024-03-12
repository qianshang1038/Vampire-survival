using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Health health;
    private void Awake()
    {
        healthBar.maxValue = health.Value;
        healthBar.value= health.Value;
        //��ʼ��Ѫ�������ֵ�ͳ�ʼֵ���趨��Ѫ����ͬ
    }
    public void UpdateUI()
    {
       healthBar.value = health.Value;
    }
}