using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.Repository.Repository;


namespace ProjectArcive_DIU.Bll.Bll
{
    public class ImageManager
    {
        ImageRepository _imageRepository = new ImageRepository();
        public bool Upload(Image image)
        {
            return _imageRepository.Upload(image);
        }
    }
}
