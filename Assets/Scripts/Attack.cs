using System.Collections;
using System.Collections.Generic;
using Timers;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private bool _canAttack =true;//��ȴϵͳ�������ι���
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
        
        if (other.CompareTag("Player"))//����Ƿ��������
        {
            var damageable = other.GetComponent<Damageable>();
            //GetComponent-��ȡ���ر��ű������
            damageable.TakeDamge(1);
            //��ʱ��
            
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
        }
    }
}
