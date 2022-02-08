
using UnityEngine;
using Vuforia;
public class FlashLight : MonoBehaviour
{
    //recibe el parametro automaticamente gracias al toogle
    public void SetFlashLight(bool enabled)
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFlash(enabled);
    }
}
