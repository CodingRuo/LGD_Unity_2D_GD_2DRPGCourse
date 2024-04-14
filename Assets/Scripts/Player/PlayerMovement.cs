using UnityEngine;

// Definiert eine Klasse "PlayerMovement", die von MonoBehaviour erbt. MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class PlayerMovement : MonoBehaviour {
    
    // Definiert eine private Variable "_speed" vom Typ float. 
    // Das [SerializeField] Attribut ermöglicht es, diese Variable im Unity-Editor zu sehen und zu ändern, obwohl sie privat ist.
    [Header("Config")]
    [SerializeField] private float _speed;

    // Definiert private Variablen für verschiedene Komponenten und Aktionen des Spielers.
    private PlayerAnimations    _playerAnimations;
    private PlayerActions       _actions;
    private Rigidbody2D         _rb2D;
    private Player              _player;
    
    // Definiert eine private Variable "_moveDirection" vom Typ Vector2.
    private Vector2             _moveDirection;

    // Die Awake-Methode wird von Unity aufgerufen, wenn das Skript initialisiert wird.
    private void Awake() {
        // Initialisiert die Aktionen und Komponenten des Spielers.
        _actions          = new PlayerActions();
        _playerAnimations = GetComponent<PlayerAnimations>();
        _rb2D             = GetComponent<Rigidbody2D>();
        _player           = GetComponent<Player>();
    }

    // Die Update-Methode wird von Unity in jedem Frame aufgerufen.
    void Update() {
        // Liest die Bewegungsrichtung des Spielers.
        ReadMovement();
    }

    // Die FixedUpdate-Methode wird von Unity in jedem festen Frame aufgerufen.
    private void FixedUpdate() {
        // Bewegt den Spieler.
        Move();
    }

    // Definiert eine private Methode "Move", die den Spieler bewegt.
    private void Move() {
        // Überprüft, ob der Gesundheitswert des Spielers kleiner oder gleich 0 ist.
        if ( _player.Stats.Health <= 0 ) return;
        // Bewegt den Spieler in die Richtung "_moveDirection" mit der Geschwindigkeit "_speed".
        _rb2D.MovePosition( _rb2D.position + _moveDirection * ( _speed * Time.fixedDeltaTime ) );
    }

    // Definiert eine private Methode "ReadMovement", die die Bewegungsrichtung des Spielers liest.
    private void ReadMovement() {
        // Liest den Bewegungswert des Spielers und normalisiert ihn.
        _moveDirection = _actions.Movement.Move.ReadValue<Vector2>().normalized;

        // Überprüft, ob die Bewegungsrichtung des Spielers null ist.
        if ( _moveDirection == Vector2.zero ) {
            // Wenn ja, setzt es die Bewegungsanimation des Spielers auf false.
            _playerAnimations.SetMoveBoolTransition( false );
            return;
        }

        // Setzt die Bewegungsanimation des Spielers auf true.
        _playerAnimations.SetMoveBoolTransition( true );

        // Setzt die Bewegungsanimation des Spielers entsprechend der Bewegungsrichtung.
        _playerAnimations.SetMoveAnimation( _moveDirection );
    }

    // Die OnEnable-Methode wird von Unity aufgerufen, wenn das Skript aktiviert wird.
    private void OnEnable() {
        // Aktiviert die Aktionen des Spielers.
        _actions.Enable();
    }

    // Die OnDisable-Methode wird von Unity aufgerufen, wenn das Skript deaktiviert wird.
    private void OnDisable() {
        // Deaktiviert die Aktionen des Spielers.
        _actions.Disable();
    }
}
