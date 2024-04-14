using UnityEngine;

// Definiert eine Klasse "PlayerExp", die von MonoBehaviour erbt. MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class PlayerExp : MonoBehaviour {
    
    // Definiert eine private Variable "_stats" vom Typ PlayerStats. 
    // Das [SerializeField] Attribut ermöglicht es, diese Variable im Unity-Editor zu sehen und zu ändern, obwohl sie privat ist.
    [Header("Config")]
    [SerializeField] private PlayerStats _stats;

    // Die Update-Methode wird von Unity in jedem Frame aufgerufen.
    private void Update() {
        // Überprüft, ob die X-Taste gedrückt wurde.
        if ( Input.GetKeyDown( KeyCode.X ) ) {
            // Wenn die X-Taste gedrückt wurde, fügt sie 300 Erfahrungspunkte hinzu.
            AddExp( 300f );
        }
    }

    // Definiert eine öffentliche Methode "AddExp", die eine bestimmte Menge an Erfahrungspunkten hinzufügt.
    public void AddExp( float amount ) {
        // Fügt die angegebene Menge an Erfahrungspunkten hinzu.
        _stats.CurrentExp += amount;

        // Überprüft, ob die aktuelle Erfahrung größer oder gleich der Erfahrung für das nächste Level ist.
        while (_stats.CurrentExp >= _stats.NextLevelExp ) {
            // Wenn ja, wird die Erfahrung für das nächste Level abgezogen und die Methode "NextLevel" aufgerufen.
            _stats.CurrentExp -= _stats.NextLevelExp;
            NextLevel();
        }
    }

    // Definiert eine private Methode "NextLevel", die das Level des Spielers erhöht und die Erfahrung für das nächste Level berechnet.
    private void NextLevel() {
        // Erhöht das Level des Spielers.
        _stats.Level++;
        // Berechnet die neue Erfahrung für das nächste Level.
        float currentExpRequired = _stats.NextLevelExp;
        float newNextLevelExp = Mathf.Round( currentExpRequired + _stats.NextLevelExp * ( _stats.ExpMultiplier / 100f ) );
        _stats.NextLevelExp = newNextLevelExp;
    }
}
