using UnityEngine;

public class Player : MonoBehaviour {
    
    [SerializeField] private PlayerStats stats;

    public PlayerStats Stats => stats;

    private PlayerAnimations _animations;

    private void Awake() {
        _animations = GetComponent<PlayerAnimations>();
    }

    public void ResetPlayer() {
        stats.ResetPlayer();
        _animations.ResetPlayer();
    }
}
