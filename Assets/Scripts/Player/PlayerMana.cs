using UnityEngine;

// Definiert eine Klasse "PlayerMana", die von MonoBehaviour erbt. MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class PlayerMana : MonoBehaviour {

    // Definiert eine private Variable "_stats" vom Typ PlayerStats. 
    // Das [SerializeField] Attribut ermöglicht es, diese Variable im Unity-Editor zu sehen und zu ändern, obwohl sie privat ist.
    [Header("Config")]
    [SerializeField] private PlayerStats _stats;

    // Die Update-Methode wird von Unity in jedem Frame aufgerufen.
    private void Update() {
        // Überprüft, ob die M-Taste gedrückt wurde.
        if ( Input.GetKeyDown( KeyCode.M ) ) {
            // Wenn die M-Taste gedrückt wurde, wird die Methode "UseMana" mit einem Wert von 1 aufgerufen.
            UseMana( 1f );
        }
    }

    // Definiert eine öffentliche Methode "UseMana", die eine bestimmte Menge an Mana verbraucht.
    public void UseMana( float amount ) {
        // Überprüft, ob das aktuelle Mana des Spielers größer oder gleich dem angegebenen Betrag ist.
        if ( _stats.Mana >= amount ) {
            // Wenn ja, wird der angegebene Betrag vom aktuellen Mana des Spielers abgezogen.
            // Die Methode Mathf.Max wird verwendet, um sicherzustellen, dass das Mana des Spielers nicht unter 0 fällt.
            _stats.Mana = Mathf.Max( _stats.Mana -= amount, 0f );
        }
    }
}