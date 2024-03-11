using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb ;
    //SerializeField ���ӻ���unity��
    private Vector2 _inputDirection;
    [SerializeField]private float _speed;
    public void Move(InputAction.CallbackContext context) //Event
    {
       _inputDirection= context.ReadValue<Vector2>();
        //����Vector2����
        //Vector2�Ƕ�ά����
        //inputSystem�ķ���������ȡ
       

    }
    private void FixedUpdate()
    {
        var position = (Vector2)transform.position;//���Ŀǰλ��
        var targetPosition = position + _inputDirection;
        if (position == targetPosition) return;
        //���ֹͣ�����鴤����

        rb.DOMove(targetPosition,_speed ).SetSpeedBased();
        //���Ŀǰλ�ü��Ϸ���
        //setSpeedBased�Ǹ���ϵͳ�����ٶȲ���ʱ��

        
    }
}
