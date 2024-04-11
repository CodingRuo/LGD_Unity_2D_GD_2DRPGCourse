using UnityEngine;

[CreateAssetMenu( fileName = "PlayerStats", menuName = "Player/PlayerStats" )]
public class PlayerStats : ScriptableObject {
    
    [Header("Config")]
    public int Level;

    [Header("Health")]
    public float Health;
    public float maxHealth;
}
