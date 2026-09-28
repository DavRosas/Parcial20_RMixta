using System.Collections;
using UnityEngine;

public class SecuenciaBebida : MonoBehaviour
{
    public GrabManager grabManager;
    public GameObject botonBeber;
    public GameObject fuegoVisual;
    public float segundos = 5f;

    bool hogueraEncendida;
    bool cocinando;

    void Start()
    {
        if (botonBeber != null)
            botonBeber.SetActive(false);

        if (fuegoVisual != null)
            fuegoVisual.SetActive(false);
    }

    public void EncenderHoguera()
    {
        if (hogueraEncendida)
            return;

        hogueraEncendida = true;

        if (fuegoVisual != null)
            fuegoVisual.SetActive(true);
    }

    public void Verter()
    {
        if (!hogueraEncendida || cocinando)
            return;

        if (grabManager == null || grabManager.heldItem == null)
            return;

        if (!grabManager.heldItem.name.Contains("Bottle"))
            return;

        GrabObject botella = grabManager.heldItem.GetComponent<GrabObject>();
        if (botella != null)
            botella.Delete();

        cocinando = true;
        StartCoroutine(EsperarYMostrarBeber());
    }

    IEnumerator EsperarYMostrarBeber()
    {
        yield return new WaitForSeconds(segundos);

        if (botonBeber != null)
            botonBeber.SetActive(true);
    }
}
