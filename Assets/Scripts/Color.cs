using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{

    private new Renderer renderer;
    private UnityEngine.Color initialColor;
    public UnityEngine.Color color;



    private void Awake()
    {
        /* Mise en cache du renderer pour éviter
         * l'appel couteux de GetComponent dans l'Update
         */
        renderer = GetComponent<Renderer>();

        // Mise en cache de la couleur initiale afin de pouvoir la restaurer
        initialColor = renderer.material.color;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        renderer.material.color = color;
    }

    private void OnMouseExit()
    {
        renderer.material.color = initialColor;
    }

    private float offset = 2f;
    private void OnMouseDown()
    {
        GameObject go = Instantiate(
            gameObject,
            transform.position + Vector3.left * offset,
            Quaternion.identity,
            null);
        Renderer goRenderer = go.GetComponent<Renderer>();
        goRenderer.material.color = UnityEngine.Color.green;
    }

}
