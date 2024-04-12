using UnityEngine;

[CreateAssetMenu( fileName = "PlayerStats", menuName = "Player/PlayerStats" )]
public class PlayerStats : ScriptableObject {
    
    [Header("Config")]
    public int Level;

    [Header("Health")]
    public float Health;
    public float MaxHealth;

    [Header("Magic")]
    public float Mana;
    public float MaxMana;

    [Header("EXP")]
    public float CurrentExp;
    public float NextLevelExp;
    public float InitialNextLevelExp;
    [Range( 1f, 100f )] public float ExpMultiplier;

    public void ResetPlayer() {
        Health       = MaxHealth;
        Mana         = MaxMana;
        Level        = 1;
        CurrentExp   = 0f;
        NextLevelExp = InitialNextLevelExp;
    }
}
