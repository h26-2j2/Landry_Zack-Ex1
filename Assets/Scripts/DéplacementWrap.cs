using UnityEngine;

public class DeplacementWarp : MonoBehaviour
{
    public float vitesseX;
    public float limiteGauche;
    public float limiteDroit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
    }
}
