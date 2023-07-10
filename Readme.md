Unity的二维码生成器

- 算法来源：https://github.com/manuelbl/QrCodeGenerator
- 只有一个dll和一个CS文件，无其它依赖。

使用方法：

1. 拷贝Demo中的 Assets/[QrCodeGenerator](D:\workspace\unity\UnityQrCodeGenerator\Assets\QrCodeGenerator)文件夹 到Unity工程中。

2. 调用接口生成二维码，返回二维码Texture2D，使用完成后需要手动销毁。

   `UnityQrCode.GeneratorTexture2D(string qrContent);`