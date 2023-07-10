using System.Collections;
using System.Collections.Generic;
using Net.Codecrete.QrCodeGenerator;
using UnityEngine;
using Color = UnityEngine.Color;

public static class UnityQrCode
{
    // 返回的 Texture2D 不使用后需要手动销毁
    public static Texture2D GeneratorTexture2D(string qrContent)
    {
        var segments = QrSegment.MakeSegments(qrContent);
        var qr = QrCode.EncodeSegments(segments, QrCode.Ecc.High, 5, 40, 2, false);

        var t2d = new Texture2D(qr.Size, qr.Size);
        t2d.filterMode = FilterMode.Point;

        for (int y = 0; y < qr.Size; y++)
        {
            for (int x = 0; x < qr.Size; x++)
            {
                var black = qr.GetModule(x, y);
                t2d.SetPixel(x, y, black ? Color.black : Color.white);
            }
        }

        t2d.Apply();

        return t2d;
    }
}
