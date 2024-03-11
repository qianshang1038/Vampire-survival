using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    
    public Vector2 Position
    {
        get { return (Vector2)playerTransform.position; }
    }

}
