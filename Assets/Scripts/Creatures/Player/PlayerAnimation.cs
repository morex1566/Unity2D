using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerAnimation : CreatureAnimation
{
    // 플레이어 프로퍼티
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        
    }


}
