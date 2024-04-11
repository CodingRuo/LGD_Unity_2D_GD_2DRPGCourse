using UnityEngine;

public class Player : MonoBehaviour {
    
    [SerializeField] private PlayerStats _stats;

    public PlayerStats Stats => _stats;
}
