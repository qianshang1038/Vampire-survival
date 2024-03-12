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
        //初始化血条的最大值和初始值与设定的血量相同
    }
    public void UpdateUI()
    {
       healthBar.value = health.Value;
    }
}
