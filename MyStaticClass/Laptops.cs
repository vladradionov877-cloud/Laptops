namespace MyStaticClass
{
    class Laptops
    {
        private static int _countItems = 0;
        private static int _maxScreenFrequency = 500;
        private static int _maxMatrixLight = 1000;
        private static int _maxSSDSize = 8;
        public static int GetCountItems() { return _countItems; }
        
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int _screenFrequency;
        public int ScreenFrequency
        {
            get { return _screenFrequency; }
            set
            {
                if (value >= _maxScreenFrequency)
                {
                    Console.WriteLine($"Частота екрану не може бути більше {_maxScreenFrequency}Гц!");
                    return;
                }
                _screenFrequency = value;
            }
        }

        private int _matrixLight;
        public int MatrixLight
        {
            get { return _matrixLight; }
            set
            {
                if (value >= _maxMatrixLight)
                {
                    Console.WriteLine($"Світло матриці не може бути більше {_maxMatrixLight}Нт!");
                    return;
                }
                _matrixLight = value;
            }
        }

        private int _ssdSize;
        public int SSDSize
        {
            get { return _ssdSize; }
            set
            {
                if (value >= _maxSSDSize)
                {
                    Console.WriteLine($"Розмір SSD не може бути більше {_maxSSDSize}Тб!");
                    return;
                }
                _ssdSize = value;
            }
        }

        // Конструктор за замовчуванням
        public Laptops()
        {
            this.Model = "-";
            this.ScreenFrequency = 0;
            this.MatrixLight = 0;
            this.SSDSize = 0;
            _countItems++;
        }

        // Конструктор з параметрами
        public Laptops(string model, int screenFrequency,
            int matrixLight, int ssdSize)
        {
            this.Model = model;
            this.ScreenFrequency = screenFrequency;
            this.MatrixLight = matrixLight;
            this.SSDSize = ssdSize;
            _countItems++;
        }

        // Статичний конструктор
        static Laptops()
        {
            _countItems = 0;
            _maxScreenFrequency = 500;
            _maxMatrixLight = 1000;
            _maxSSDSize = 8;
        }


        public override string ToString()
        {
            return
                $"\nМодель: {Model}" +
                $"\nЧастота: {ScreenFrequency}Гц" +
                $"\nСвітло матриці: {MatrixLight}Нт" +
                $"\nSSD: {SSDSize}Тб";
        }

    }
}


