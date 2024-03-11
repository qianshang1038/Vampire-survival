using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb ;
    //SerializeField 可视化于unity中
    private Vector2 _inputDirection;
    [SerializeField]private float _speed;
    public void Move(InputAction.CallbackContext context) //Event
    {
       _inputDirection= context.ReadValue<Vector2>();
        //存在Vector2里面
        //Vector2是二维向量
        //inputSystem的方向向量读取
       

    }
    private void FixedUpdate()
    {
        var position = (Vector2)transform.position;//玩家目前位置
        var targetPosition = position + _inputDirection;
        if (position == targetPosition) return;
        //解决停止不动抽搐问题

        rb.DOMove(targetPosition,_speed ).SetSpeedBased();
        //玩家目前位置加上方向
        //setSpeedBased是告诉系统这是速度不是时间

        
    }
}
