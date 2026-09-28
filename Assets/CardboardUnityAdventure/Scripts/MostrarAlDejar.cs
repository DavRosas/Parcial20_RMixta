using UnityEngine;

public class MostrarAlDejar : MonoBehaviour
{
    public GameObject mensaje;
    public string nombre = "Book";

    PlateBehaviour placa;
    bool yaMostro;

    void Start()
    {
        placa = GetComponent<PlateBehaviour>();
        OcultarTodos();
    }

    void Update()
    {
        if (mensaje == null || placa == null)
            return;

        bool libroEnBase = placa.heldObject != null && placa.heldObject.name.Contains(nombre);

        if (libroEnBase && !yaMostro)
        {
            OcultarTodos();
            mensaje.SetActive(true);
            yaMostro = true;
        }
        else if (!libroEnBase && yaMostro)
        {
            OcultarTodos();
            yaMostro = false;
        }
    }

    void OcultarTodos()
    {
        if (mensaje == null)
            return;

        Transform padre = mensaje.transform.parent;
        bool padreEsCanvas = padre != null && padre.GetComponent<Canvas>() != null;

        if (padre == null || padreEsCanvas)
        {
            mensaje.SetActive(false);
            return;
        }

        foreach (Transform hijo in padre)
            hijo.gameObject.SetActive(false);
    }
}
