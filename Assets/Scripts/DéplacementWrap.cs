using UnityEngine;

public class DeplacementWarp : MonoBehaviour
{
    public float vitesseX;
    public float vitesseY;
    public float limiteGauche;
    public float limiteDroit;
    public float limiteHaut;
    public float limiteBas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculer valeur aléatoire
        int vitesseX = Random.Range(-5, 5);
        int vitesseY = Random.Range(-5, 5);

        // Appliquer la valeur à la position X et Y de l'objet

    }

    // Update is called once per frame
    void Update()
    {

        // Logique de deplacement
        transform.position += new Vector3(vitesseX, 0, 0) * Time.deltaTime;

        if (transform.position.x < limiteGauche)
        {
            transform.position = new Vector3(limiteDroit, transform.position.y);
        }
        transform.position += new Vector3( 0, vitesseY, 0) * Time.deltaTime;

        if (transform.position.y < limiteBas)
        {
            transform.position = new Vector3(limiteHaut, transform.position.x);
        }
    }

}
