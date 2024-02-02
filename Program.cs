//ovaj obrazac je proxy, strukturni obrazac.


    interface IImage
    {
        void Display();
    }
    class RealImage : IImage
    {
        private string filename;
        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }
        public void Display()
        {
            Console.WriteLine($"Displaying image: {filename}");
        }
        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {filename}");
        }
    }
    class ImageProxy : IImage
    {
        private string filename;
        private RealImage image;
        public ImageProxy(string filename)
        {
            this.filename = filename;
        }
        public void Display()
        {
            if (image == null)
            {
                image = new RealImage(filename);
            }
            image.Display();
        }
    }


    class Program
    {
        static void Main()
        {
           
            IImage image = new ImageProxy("example.jpg");   
            image.Display();           
            image.Display();
        }
    }


