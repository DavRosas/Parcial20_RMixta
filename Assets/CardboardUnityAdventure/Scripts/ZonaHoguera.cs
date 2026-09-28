using UnityEngine;

public class ZonaHoguera : MonoBehaviour
{
    public SecuenciaBebida secuencia;

    public void OnPointerClickXR()
    {
        if (secuencia != null)
            secuencia.EncenderHoguera();
    }
}