using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Definiert eine Klasse "UIManager", die von MonoBehaviour erbt. MonoBehaviour ist die Basis-Klasse für alle Unity Skripte.
public class UIManager : MonoBehaviour {
    
    // Definiert eine private Variable "_playerStats" vom Typ PlayerStats. 
    // Das [SerializeField] Attribut ermöglicht es, diese Variable im Unity-Editor zu sehen und zu ändern, obwohl sie privat ist.
    [Header("Stats")]
    [SerializeField] private PlayerStats _playerStats;

    // Definiert private Variablen für die UI-Elemente der Gesundheits-, Mana- und Erfahrungsleisten.
    [Header("Bars")]
    [SerializeField] private Image _healthBar;
    [SerializeField] private Image _manaBar;
    [SerializeField] private Image _expBar;

    // Definiert private Variablen für die UI-Elemente der Textanzeigen für Level, Gesundheit, Mana und Erfahrung.
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI _levelTMP;
    [SerializeField] private TextMeshProUGUI _healthTMP;
    [SerializeField] private TextMeshProUGUI _manaTMP;
    [SerializeField] private TextMeshProUGUI _expTMP;

    // Die Update-Methode wird von Unity in jedem Frame aufgerufen.
    private void Update() {
        // Aktualisiert die Spieler-UI in jedem Frame.
        UpdatePlayerUI();
    }

    // Definiert eine private Methode "UpdatePlayerUI", die die Spieler-UI aktualisiert.
    private void UpdatePlayerUI() {

        // Setzt den Füllstand der Gesundheitsleiste. 
        // Mathf.Lerp wird verwendet, um einen sanften Übergang zwischen dem aktuellen Füllstand und dem Zielwert zu erzeugen.
        // Der Zielwert ist das Verhältnis von aktueller Gesundheit zu maximaler Gesundheit.
        // 10f * Time.deltaTime bestimmt die Geschwindigkeit des Übergangs.
        _healthBar.fillAmount = Mathf.Lerp( _healthBar.fillAmount, _playerStats.Health / _playerStats.MaxHealth, 10f * Time.deltaTime );

        // Ähnlich wie oben, aber für die Manaleiste.
        _manaBar.fillAmount = Mathf.Lerp( _manaBar.fillAmount, _playerStats.Mana / _playerStats.MaxMana, 10f * Time.deltaTime );

        // Ähnlich wie oben, aber für die Erfahrungsleiste.
        _expBar.fillAmount = Mathf.Lerp( _expBar.fillAmount, _playerStats.CurrentExp / _playerStats.NextLevelExp, 10f * Time.deltaTime );

        // Setzt den Text des Level-Labels auf "Level {aktueller Level}".
        _levelTMP.text  = $"Level {_playerStats.Level}";

        // Setzt den Text des Gesundheits-Labels auf "{aktuelle Gesundheit} / {maximale Gesundheit}".
        _healthTMP.text = $"{_playerStats.Health} / {_playerStats.MaxHealth}";

        // Setzt den Text des Mana-Labels auf "{aktuelles Mana} / {maximales Mana}".
        _manaTMP.text   = $"{_playerStats.Mana} / {_playerStats.MaxMana}";

        // Setzt den Text des Erfahrungs-Labels auf "{aktuelle Erfahrung} / {Erfahrung für nächstes Level}".
        _expTMP.text    = $"{_playerStats.CurrentExp} / {_playerStats.NextLevelExp}";
    }
}
