namespace WebApplication3.Model.ShoppingCartReciver
{
    public class Option
    {
        public int? type { get; set; }
        public bool requirement { get; set; }
        public int? key { get; set; }
        public string name { get; set; }
        public string memo { get; set; }
        public dynamic optionVaules { get; set; }
    }

    public class OptionVaule
    {
        public string valueName { get; set; }
        public string valueKey { get; set; }
        public int price { get; set; }
        public bool beChoise { get; set; }
        public string content { get; set; }
        public string title { get; set; }
        public string dishKey { get; set; }
        public string unit { get; set; }
        public string imgPath { get; set; }
        public dynamic options { get; set; }
    }

    public class Product
    {
        public string title { get; set; }
        public string dishKey { get; set; }
        public string unit { get; set; }
        public string imgPath { get; set; }
        public int price { get; set; }
        public bool isCombo { get; set; }
        public List<Option>? options { get; set; }
    }

    public class ShoppingCartReciverModel
    {
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}
