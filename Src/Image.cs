using System;

namespace Medoz.Docker;

public class Image
{
    public Image()
    {
    }

    public string Repository { set; get; }
    public string Tag { set; get; }
    public string ImageId { set; get; }
    public string Created { set; get; }
    public string Size { set; get; }
}