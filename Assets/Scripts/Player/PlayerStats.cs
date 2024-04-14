using UnityEngine;

// Definiert eine Klasse "PlayerStats", die von ScriptableObject erbt. 
// ScriptableObjects in Unity ermöglichen die Erstellung von anpassbaren Daten-Assets im Unity-Editor.
// Das Attribut [CreateAssetMenu] ermöglicht es, eine neue Instanz dieses ScriptableObjects über das Unity-Menü zu erstellen.
[CreateAssetMenu( fileName = "PlayerStats", menuName = "Player/PlayerStats" )]
public class PlayerStats : ScriptableObject {
    
    // Definiert eine öffentliche Variable "Level" vom Typ int.
    [Header("Config")]
    public int Level;

    // Definiert öffentliche Variablen für die Gesundheit des Spielers.
    [Header("Health")]
    public float Health;
    public float MaxHealth;

    // Definiert öffentliche Variablen für das Mana des Spielers.
    [Header("Magic")]
    public float Mana;
    public float MaxMana;

    // Definiert öffentliche Variablen für die Erfahrungspunkte (EXP) des Spielers.
    [Header("EXP")]
    public float CurrentExp;
    public float NextLevelExp;
    public float InitialNextLevelExp;
    // Das Attribut [Range] beschränkt den Wert dieser Variable auf einen Bereich zwischen 1 und 100 im Unity-Editor.
    [Range( 1f, 100f )] public float ExpMultiplier;

    // Definiert eine öffentliche Methode "ResetPlayer", die die Werte des Spielers auf ihre Anfangswerte zurücksetzt.
    public void ResetPlayer() {
        // Setzt die Gesundheit und das Mana des Spielers auf ihre maximalen Werte.
        Health       = MaxHealth;
        Mana         = MaxMana;
        // Setzt das Level des Spielers auf 1.
        Level        = 1;
        // Setzt die aktuellen EXP des Spielers auf 0.
        CurrentExp   = 0f;
        // Setzt die EXP für das nächste Level auf den Anfangswert.
        NextLevelExp = InitialNextLevelExp;
    }
}
