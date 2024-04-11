using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    [Header("Config")]
    [SerializeField] private float speed;

    private readonly int moveX    = Animator.StringToHash( "MoveX" );
    private readonly int moveY    = Animator.StringToHash( "MoveY" );
    private readonly int isMoving = Animator.StringToHash( "isMoving" );

    private PlayerActions   actions;
    private Rigidbody2D     rb2D;
    private Animator        animator;
    private Vector2         moveDirection;

    private void Awake() {
        actions  = new PlayerActions();
        animator = GetComponent<Animator>();
        rb2D     = GetComponent<Rigidbody2D>();
    }

    void Update() {
        ReadMovement();
    }

    private void FixedUpdate() {
        Move();
    }

    private void Move() {
        rb2D.MovePosition( rb2D.position + moveDirection * ( speed * Time.fixedDeltaTime ) );
    }

    private void ReadMovement() {

        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;

        if ( moveDirection == Vector2.zero ) {
            animator.SetBool( isMoving, false );
            return;
        }

        animator.SetBool( isMoving, true );

        animator.SetFloat( moveX, moveDirection.x );
        animator.SetFloat( moveY, moveDirection.y );

    }

    private void OnEnable() {
        actions.Enable();
    }

    private void OnDisable() {
        actions.Disable();
    }
}
