using UnityEngine;

public class random : MonoBehaviour
{
    public int chanceVitesse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculer valeur aléatoire
        int positionX = Random.Range(-6, 6);
        // Appliquer la valeur à la position X de l'objet
        transform.position = new Vector2(positionX, transform.position.y);

        if (Random.Range(0, 100) < chanceVitesse)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
