using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable {

    [Header("Config")]
    [SerializeField] private PlayerStats _playerStats;

    private void Update() {
        if ( Input.GetKeyDown( KeyCode.P ) ) {
            TakeDamage( 1f );
        }
    }

    public void TakeDamage( float amount ) {

        _playerStats.Health -= amount;
        if ( _playerStats.Health <= 0f ) {
            PlayerDead();
        }
    }

    private void PlayerDead() {
        Debug.Log("DEAD");
    }
}
