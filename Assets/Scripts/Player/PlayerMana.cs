using UnityEngine;

public class PlayerMana : MonoBehaviour {

    [Header("Config")]
    [SerializeField] private PlayerStats _stats;

     private void Update() {
        if ( Input.GetKeyDown( KeyCode.M ) ) {
            UseMana( 1f );
        }
    }

    public void UseMana( float amount ) {

        if ( _stats.Mana >= amount ) {

            _stats.Mana = Mathf.Max( _stats.Mana -= amount, 0f );
        }
    }
}
