using UnityEngine;

// Definiert eine Klasse "PlayerAnimations", die von MonoBehaviour erbt. MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class PlayerAnimations : MonoBehaviour {

    // Definiert private Konstanten für die verschiedenen Animator-Parameter.
    // Animator.StringToHash wird verwendet, um die Performance zu verbessern, indem die Strings in Hashes umgewandelt werden.
    private readonly int moveX    = Animator.StringToHash( "MoveX" );
    private readonly int moveY    = Animator.StringToHash( "MoveY" );
    private readonly int isMoving = Animator.StringToHash( "isMoving" );
    private readonly int isDead   = Animator.StringToHash( "isDead" );
    private readonly int Revive   = Animator.StringToHash( "Revive" );

    // Definiert eine private Variable "_animator" vom Typ Animator.
    private Animator _animator;

    // Die Awake-Methode wird von Unity aufgerufen, wenn das Skript initialisiert wird.
    private void Awake() {
        // Ruft die Komponente vom Typ Animator ab, die am selben GameObject angehängt ist wie dieses Skript.
        _animator = GetComponent<Animator>();
    }

    // Definiert eine öffentliche Methode "SetDeadAnimation", die den "isDead" Trigger des Animators setzt.
    public void SetDeadAnimation() {
        _animator.SetTrigger( isDead );
    }

    // Definiert eine öffentliche Methode "SetMoveBoolTransition", die den "isMoving" Bool-Wert des Animators setzt.
    public void SetMoveBoolTransition( bool value ) {
        _animator.SetBool( isMoving, value );
    }

    // Definiert eine öffentliche Methode "SetMoveAnimation", die die "moveX" und "moveY" Float-Werte des Animators setzt.
    public void SetMoveAnimation( Vector2 direction ) {
        _animator.SetFloat( moveX, direction.x );
        _animator.SetFloat( moveY, direction.y );
    }

    // Definiert eine öffentliche Methode "ResetPlayer", die die Bewegungsanimation auf "nach unten" setzt und den "Revive" Trigger des Animators setzt.
    public void ResetPlayer() {
        SetMoveAnimation( Vector2.down );
        _animator.SetTrigger( Revive );
    }
}
