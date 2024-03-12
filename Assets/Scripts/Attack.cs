using System.Collections;
using System.Collections.Generic;
using Timers;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private bool _canAttack =true;//冷却系统避免数次攻击
    private void OnTriggerEnter2D(Collider2D col)
    {
        DealDamage(col);
    }
    private void CanAttack()
    {
        _canAttack=true;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }
    private void DealDamage(Collider2D other)
    {
        if (!_canAttack) return;
        
        if (other.CompareTag("Player"))//检测是否碰到玩家
        {
            var damageable = other.GetComponent<Damageable>();
            //GetComponent-获取挂载本脚本的组件
            damageable.TakeDamge(1);
            //计时器
            
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
        }
    }
}
