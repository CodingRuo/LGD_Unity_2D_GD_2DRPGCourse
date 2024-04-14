// Definiert eine öffentliche Schnittstelle "IDamageable".
public interface IDamageable {
    
    // Diese Schnittstelle definiert eine Methode "TakeDamage", die einen float-Wert als Parameter akzeptiert.
    // Jede Klasse, die diese Schnittstelle implementiert, muss diese Methode definieren.
    void TakeDamage( float amount );
}