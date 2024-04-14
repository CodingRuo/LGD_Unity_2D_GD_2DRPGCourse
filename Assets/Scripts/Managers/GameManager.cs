using UnityEngine;

// Definiert eine Klasse "GameManager", die von MonoBehaviour erbt. MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class GameManager : MonoBehaviour {

    // Definiert eine private Variable "_player" vom Typ Player. 
    // Das [SerializeField] Attribut ermöglicht es, diese Variable im Unity-Editor zu sehen und zu ändern, obwohl sie privat ist.
    [SerializeField] private Player _player;

    // Die Update-Methode wird von Unity in jedem Frame aufgerufen.
    private void Update() {
        // Überprüft, ob die R-Taste gedrückt wurde.
        if (Input.GetKeyDown(KeyCode.R)) {
            // Wenn die R-Taste gedrückt wurde, wird die Methode "ResetPlayer" aufgerufen, die den Spieler auf seinen Anfangszustand zurücksetzt.
            _player.ResetPlayer();
        }
    }
}