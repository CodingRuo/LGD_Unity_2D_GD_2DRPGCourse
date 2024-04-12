using UnityEngine;

public class PlayerAnimations : MonoBehaviour {

    private readonly int moveX    = Animator.StringToHash( "MoveX" );
    private readonly int moveY    = Animator.StringToHash( "MoveY" );
    private readonly int isMoving = Animator.StringToHash( "isMoving" );
    private readonly int isDead   = Animator.StringToHash( "isDead" );
    private readonly int Revive   = Animator.StringToHash( "Revive" );

    private Animator _animator;

    private void Awake() {
        _animator = GetComponent<Animator>();
    }

    public void SetDeadAnimation() {
        _animator.SetTrigger( isDead );
    }

    public void SetMoveBoolTransition( bool value ) {
        _animator.SetBool( isMoving, value );
    }

    public void SetMoveAnimation( Vector2 direction ) {
        _animator.SetFloat( moveX, direction.x );
        _animator.SetFloat( moveY, direction.y );
    }

    public void ResetPlayer() {
        SetMoveAnimation( Vector2.down );
        _animator.SetTrigger( Revive );
    }
}
