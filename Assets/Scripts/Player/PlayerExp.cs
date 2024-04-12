using UnityEngine;

public class PlayerExp : MonoBehaviour {
    
    [Header("Config")]
    [SerializeField] private PlayerStats _stats;

    private void Update() {
        if ( Input.GetKeyDown( KeyCode.X ) ) {
            AddExp( 300f );
        }
    }

    public void AddExp( float amount ) {
        _stats.CurrentExp += amount;

        while (_stats.CurrentExp >= _stats.NextLevelExp ) {
            _stats.CurrentExp -= _stats.NextLevelExp;
            NextLevel();
        }
    }

    private void NextLevel() {
        _stats.Level++;
        float currentExpRequired = _stats.NextLevelExp;
        float newNextLevelExp = Mathf.Round( currentExpRequired + _stats.NextLevelExp * ( _stats.ExpMultiplier / 100f ) );
        _stats.NextLevelExp = newNextLevelExp;
    }
}
