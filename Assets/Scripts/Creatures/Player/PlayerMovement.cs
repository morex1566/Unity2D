using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public partial class PlayerMovement : CreatureMovement
{
    // 플레이어 프로퍼티
    private Player                  player;

    private Vector2                 inputDirection;
    private PlayerMovementState     movementState = PlayerMovementState.Idle;
    private PlayerActionState       actionState = PlayerActionState.Idle;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    protected override void Move()
    {
        Vector3 moveDistance = inputDirection * player.Status.speed * Time.fixedDeltaTime;
        transform.position += moveDistance;

        movementState = moveDistance.magnitude > 0f ?
            PlayerMovementState.Move : PlayerMovementState.Idle;
    }
}

public partial class PlayerMovement
{
    public PlayerMovementState MovementState
    {
        get => movementState;
        set => movementState = value;
    }

    public PlayerActionState ActionState
    {
        get => actionState;
        set => actionState = value;
    }

    public Vector2 InputDirection
    {
        get => inputDirection;
        set => inputDirection = value;
    }
}
