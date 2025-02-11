namespace TheFirm;

// De interface gebruik je om de INTERACTIE tussen objecten te ONTKOPPELEN.
// Is een can-do relatie (vgl inheritance is-a relatie)
interface IContract
{
    // Dit gedrag MOET geimplementeerd worden.
    void Werkt();
}
