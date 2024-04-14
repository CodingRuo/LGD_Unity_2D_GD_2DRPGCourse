using UnityEngine;

// Definiert eine Klasse "Player", die von MonoBehaviour erbt. MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class Player : MonoBehaviour {
    
    // Definiert eine private Variable "stats" vom Typ PlayerStats. 
    // Das [SerializeField] Attribut ermöglicht es, diese Variable im Unity-Editor zu sehen und zu ändern, obwohl sie privat ist.
    [SerializeField] private PlayerStats stats;

    // Definiert eine öffentliche Eigenschaft "Stats", die den Zugriff auf die private Variable "stats" ermöglicht.
    public PlayerStats Stats => stats;

    // Definiert eine private Variable "_animations" vom Typ PlayerAnimations.
    private PlayerAnimations _animations;

    // Die Awake-Methode wird von Unity aufgerufen, wenn das Skript initialisiert wird.
    private void Awake() {
        // Ruft die Komponente vom Typ PlayerAnimations ab, die am selben GameObject angehängt ist wie dieses Skript.
        _animations = GetComponent<PlayerAnimations>();
    }

    // Definiert eine öffentliche Methode "ResetPlayer", die die ResetPlayer-Methoden der "stats" und "_animations" Objekte aufruft.
    public void ResetPlayer() {
        stats.ResetPlayer();
        _animations.ResetPlayer();
    }
}
