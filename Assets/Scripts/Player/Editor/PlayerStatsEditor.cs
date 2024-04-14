using UnityEditor;
using UnityEngine;

// Definiert einen benutzerdefinierten Editor für das PlayerStats-Objekt.
// CustomEditor ist ein Attribut, das angibt, dass diese Klasse einen benutzerdefinierten Editor für ein bestimmtes Objekt bereitstellt.
[CustomEditor( typeof( PlayerStats ) )]
public class PlayerStatsEditor : Editor {

    // Eine Eigenschaft, die das aktuell ausgewählte Objekt in der Unity-Inspektoransicht in ein PlayerStats-Objekt umwandelt.
    private PlayerStats StatsTarget => target as PlayerStats;

    // Überschreibt die OnInspectorGUI-Methode, die die Unity-Inspektoransicht für das PlayerStats-Objekt definiert.
    public override void OnInspectorGUI() {
        
        // Ruft die Basisversion der OnInspectorGUI-Methode auf, um die Standardinspektoransicht zu zeichnen.
        base.OnInspectorGUI();

        // Zeichnet einen Button mit der Beschriftung "Reset Player". Wenn dieser Button gedrückt wird, wird die ResetPlayer-Methode auf dem PlayerStats-Objekt aufgerufen.
        if ( GUILayout.Button("Reset Player") ) {
            StatsTarget.ResetPlayer();
        }
    }
}
