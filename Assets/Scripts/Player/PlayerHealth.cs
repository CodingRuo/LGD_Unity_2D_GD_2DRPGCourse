using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable {

    [Header("Config")]
    [SerializeField] private PlayerStats _stats;

    private PlayerAnimations _playerAnimations;

    private void Awake() {
        _playerAnimations = GetComponent<PlayerAnimations>();
    }

    private void Update() {
        if ( Input.GetKeyDown( KeyCode.P ) ) {
            TakeDamage( 1f );
        }
    }

    public void TakeDamage( float amount ) {

        _stats.Health -= amount;
        if ( _stats.Health <= 0f ) {
            PlayerDead();
        }
    }

    private void PlayerDead() {
        _playerAnimations.SetDeadAnimation();
    }
}
