using UnityEngine;

// Definiert eine Klasse "PlayerHealth", die von MonoBehaviour erbt und das Interface "IDamageable" implementiert. 
// MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class PlayerHealth : MonoBehaviour, IDamageable {

    // Definiert eine private Variable "_stats" vom Typ PlayerStats. 
    // Das [SerializeField] Attribut ermöglicht es, diese Variable im Unity-Editor zu sehen und zu ändern, obwohl sie privat ist.
    [Header("Config")]
    [SerializeField] private PlayerStats _stats;

    // Definiert eine private Variable "_playerAnimations" vom Typ PlayerAnimations.
    private PlayerAnimations _playerAnimations;

    // Die Awake-Methode wird von Unity aufgerufen, wenn das Skript initialisiert wird.
    private void Awake() {
        // Ruft die Komponente vom Typ PlayerAnimations ab, die am selben GameObject angehängt ist wie dieses Skript.
        _playerAnimations = GetComponent<PlayerAnimations>();
    }

    // Die Update-Methode wird von Unity in jedem Frame aufgerufen.
    private void Update() {
        // Überprüft, ob die P-Taste gedrückt wurde.
        if ( Input.GetKeyDown( KeyCode.P ) ) {
            // Wenn die P-Taste gedrückt wurde, wird die Methode "TakeDamage" mit einem Schaden von 1 aufgerufen.
            TakeDamage( 1f );
        }
    }

    // Definiert eine öffentliche Methode "TakeDamage", die eine bestimmte Menge an Schaden verarbeitet.
    public void TakeDamage( float amount ) {
        // Zieht die angegebene Menge vom Gesundheitswert des Spielers ab.
        _stats.Health -= amount;
        // Überprüft, ob der Gesundheitswert des Spielers kleiner oder gleich 0 ist.
        if ( _stats.Health <= 0f ) {
            // Wenn ja, wird die Methode "PlayerDead" aufgerufen.
            PlayerDead();
        }
    }

    // Definiert eine private Methode "PlayerDead", die die Todesanimation des Spielers setzt.
    private void PlayerDead() {
        _playerAnimations.SetDeadAnimation();
    }
}
