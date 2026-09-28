using UnityEngine;

public class ZonaOlla : MonoBehaviour
{
    public SecuenciaBebida secuencia;

    public void OnPointerClickXR()
    {
        if (secuencia != null)
            secuencia.Verter();
    }
}