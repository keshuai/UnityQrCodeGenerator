using TMPro;
using UnityEngine;

public class QrCodeSample : MonoBehaviour
{
    [SerializeField]private TMP_InputField _input;
    [SerializeField]private UnityEngine.UI.RawImage _rawImage;
    
    private void Start()
    {
        _input.text = "请在这里输入二维码信息";
    }

    private void OnDestroy()
    {
        DestroyTexture2D();
    }

    private void DestroyTexture2D()
    {
        if (_rawImage.mainTexture != null)
        {
            Destroy(_rawImage.texture);
            _rawImage.texture = null;
        }
    }

    public void OnClickButton()
    {
        var t2d = UnityQrCode.GeneratorTexture2D(_input.text);
        DestroyTexture2D();
        _rawImage.texture = t2d;
    }
}
